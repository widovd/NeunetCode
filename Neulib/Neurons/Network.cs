﻿using System;
using System.IO;
using System.Collections.Generic;
using Neulib.Exceptions;
using Neulib.Numerics;
using Neulib.Serializers;
using static Neulib.Extensions.FloatExtensions;
using System.Collections;

namespace Neulib.Neurons
{
    public class Network : BaseObject, IList<Layer>
    {
        // ----------------------------------------------------------------------------------------
        #region Properties

        private List<Layer> Layers { get; set; } = new List<Layer>();

        public int Count => Layers.Count;

        public bool IsReadOnly => ((ICollection<Layer>)Layers).IsReadOnly;

        public Layer this[int index]
        {
            get { return Layers[index]; }
            set
            {
                Layers[index] = value;
                if (index > 0) value.SetConnections(Layers[index - 1].Count);
                if (index + 1 < Count) Layers[index + 1].SetConnections(value.Count);
            }
        }

        public Layer First { get => Layers.Count > 0 ? Layers[0] : null; }

        public Layer Last { get => Layers.Count > 0 ? Layers[Layers.Count - 1] : null; }

        public int InputCount { get => First.Count; }

        public int OutputCount { get => Last.Count; }

        #endregion
        // ----------------------------------------------------------------------------------------
        #region Constructors

        public Network()
        {
        }

        public Network(Stream stream, BinarySerializer serializer)
        {
            int count = stream.ReadInt();
            for (int i = 0; i < count; i++)
            {
                Layers.Add((Layer)stream.ReadValue(serializer));
            }
        }

        #endregion
        // ----------------------------------------------------------------------------------------
        #region IList

        public int IndexOf(Layer layer)
        {
            return Layers.IndexOf(layer);
        }

        public void Insert(int index, Layer layer)
        {
            Layers.Insert(index, layer);
            if (index > 0) layer.SetConnections(Layers[index - 1].Count);
            if (index + 1 < Count) Layers[index + 1].SetConnections(layer.Count);
        }

        public void Add(Layer layer)
        // Initializes the connections
        {
            Layers.Add(layer);
            if (Count > 1) layer.SetConnections(Layers[Count - 2].Count);
        }

        public void RemoveAt(int index)
        {
            Layers.RemoveAt(index);
            if (index > 0) Layers[index].SetConnections(Layers[index - 1].Count);
        }

        public bool Remove(Layer layer)
        {
            int index = Layers.IndexOf(layer);
            if (index < 0) return false;
            RemoveAt(index);
            return true;
        }

        public void Clear()
        {
            Layers.Clear();
        }

        public bool Contains(Layer item)
        {
            return Layers.Contains(item);
        }

        public void CopyTo(Layer[] array, int arrayIndex)
        {
            Layers.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Layer> GetEnumerator()
        {
            return Layers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Layers.GetEnumerator();
        }

        #endregion
        // ----------------------------------------------------------------------------------------
        #region BaseObject

        protected override void CopyFrom(object o)
        {
            base.CopyFrom(o);
            Network value = o as Network ?? throw new InvalidTypeException(o, nameof(Network), 473835);
            Layers.Clear();
            int count = value.Layers.Count;
            for (int i = 0; i < count; i++)
                Layers.Add((Layer)value.Layers[i].Clone());
        }

        public override void WriteToStream(Stream stream, BinarySerializer serializer)
        {
            base.WriteToStream(stream, serializer);
            int count = Layers.Count;
            stream.WriteInt(count);
            for (int i = 0; i < count; i++)
                stream.WriteValue(Layers[i], serializer);
        }

        #endregion
        // ----------------------------------------------------------------------------------------
        #region Network

        public void Randomize(Random random, float biasMagnitude, float weightMagnitude)
        {
            int count = Layers.Count;
            for (int i = 0; i < count; i++)
                Layers[i].Randomize(random, biasMagnitude, weightMagnitude);
        }

        public void FeedForward(Single1D xs, Single1D ys)
        {
            if (xs == null) throw new VarNullException(nameof(xs), 850330);

            int count = Layers.Count;
            Layer layer = null;
            for (int i = 0; i < count; i++)
            {
                Layer prevLayer = layer;
                layer = Layers[i];
                if (prevLayer == null)
                    layer.SetActivations(xs);
                else
                    layer.Calculate(prevLayer);
            }
            layer.GetActivations(ys);
        }

        private static float CostFunction(Single1D ys1, Single1D ys2)
        {
            float cost = 0;
            int n = ys1.Count;
            if (n != ys2.Count) throw new UnequalValueException(n, ys2.Count, 109047);
            for (int i = 0; i < n; i++)
            {
                cost += Sqr(ys1[i] - ys2[i]);
            }
            return cost / (2f * n);
        }

        public float GetCostAndDerivatives(
            SampleList samples, Single1D derivatives, MeasurementList measurements,
            CalculationArguments arguments)
        {
            int nSamples = samples.Count;
            int nCoeffs = derivatives.Count;
            float cost = 0f;
            for (int i = 0; i < nCoeffs; i++) derivatives[i] = 0f;
            for (int iSample = 0; iSample < nSamples; iSample++)
            {
                arguments.ThrowIfCancellationRequested();
                Sample sample = samples[iSample];
                Single1D measurement = measurements[iSample];
                FeedForward(sample.Inputs, measurement);
                cost += CostFunction(measurement, sample.Requirements);
                FeedBackward(sample.Requirements);
                AddDerivatives(derivatives);
                arguments.reporter?.ReportProgress(iSample, nSamples);
            }
            arguments.reporter?.ReportProgress(0, nSamples);
            cost /= nSamples;
            for (int i = 0; i < nCoeffs; i++) derivatives[i] /= nSamples;
            return cost;
        }

        public void Learn(SampleList samples, CalculationArguments arguments)
        // samples = yjks
        {
            int nSamples = samples.Count; // number of sample rows
            int nCoefficients = CoefficientCount();
            // Current biasses and weights of the neurons in this network:
            Single1D coefficients = new Single1D(nCoefficients);
            // The derivatives of the cost with respect to the biasses and weights:
            Single1D derivatives = new Single1D(nCoefficients);
            MeasurementList measurements = new MeasurementList(nSamples, OutputCount);
            GetCoefficients(coefficients);
            Minimization minimization = new Minimization()
            {
                MaxIter = arguments.settings.MaxIter,
                Eps = arguments.settings.Epsilon,
                Tol = arguments.settings.Tolerance,
            };
            minimization.SteepestDescent(coefficients, derivatives, (iter) =>
            {
                SetCoefficients(coefficients);
                arguments.reporter?.ReportCoefficients(coefficients);
                float cost = GetCostAndDerivatives(samples, derivatives, measurements, arguments);
                arguments.reporter?.ReportCostAndDerivatives(cost, derivatives, measurements);
                return cost;
            }, arguments.settings.LearningRate);
        }


        #endregion
        // ----------------------------------------------------------------------------------------
        #region Network

        public void ForEach(Action<Layer> action, bool skipFirst)
        {
            int count = Layers.Count;
            for (int i = skipFirst ? 1 : 0; i < count; i++)
            {
                action(Layers[i]);
            }
        }

        private void FeedBackward(Single1D ys)
        {
            if (ys == null) throw new VarNullException(nameof(ys), 411263);
            int count = Layers.Count;
            Layer layer = null;
            for (int i = count - 1; i >= 0; i--)
            {
                Layer nextLayer = layer;
                layer = Layers[i];
                if (nextLayer == null)
                    layer.CalculateDeltas(ys);
                else
                    layer.FeedBackward(nextLayer);
            }
        }


        /// <summary>
        /// Returns the total number of biasses and weights of all neurons in this network except the first layer.
        /// </summary>
        public int CoefficientCount()
        {
            int h = 0;
            ForEach(layer =>
            {
                layer.ForEach((Neuron neuron) =>
                {
                    h += neuron.Count + 1;
                });
            }, true);
            return h;
        }

        public Single1D CreateCoefficients()
        {
            return new Single1D(CoefficientCount());
        }

        /// <summary>
        /// Sets the biasses and weights of all neurons in this network.
        /// </summary>
        /// <param name="coefficients">The coefficients.</param>
        public void SetCoefficients(Single1D coefficients)
        {
            int h = 0;
            ForEach(layer =>
            {
                layer.ForEach((Neuron neuron) =>
                {
                    neuron.Bias = coefficients[h++];
                    neuron.ForEach(connection =>
                    {
                        connection.Weight = coefficients[h++];
                    });
                });
            }, true);
        }

        /// <summary>
        /// Gets the biasses and weights of all neurons in this network.
        /// </summary>
        /// <param name="coefficients">The coefficients.</param>
        public void GetCoefficients(Single1D coefficients)
        {
            int h = 0;
            ForEach(layer =>
            {
                layer.ForEach((Neuron neuron) =>
                {
                    coefficients[h++] = neuron.Bias;
                    neuron.ForEach(connection =>
                    {
                        coefficients[h++] = connection.Weight;
                    });
                });
            }, true);
        }

        public Single1D GetCoefficients()
        {
            Single1D coefficients = CreateCoefficients();
            GetCoefficients(coefficients);
            return coefficients;
        }

        /// <summary>
        /// Fills a float array with the biasses and weights of all neurons in this network.
        /// </summary>
        /// <param name="derivatives">The float array which must have been created.</param>
        private void AddDerivatives(Single1D derivatives)
        {
            int h = 0;
            Layer layer = null;
            int count = Layers.Count;
            for (int i = 0; i < count; i++)
            {
                Layer prevLayer = layer;
                layer = Layers[i];
                if (prevLayer == null) continue;
                layer.ForEach(neuron =>
                {
                    float delta = neuron.Delta;
                    derivatives[h++] += delta; // dC/dbj
                    neuron.ForEach((connection, k) =>
                    {
                        derivatives[h++] += prevLayer[k].Activation * delta; // dC/dwjk
                    });
                });
            }
        }


        #endregion
    }
}
