﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Neulib.Exceptions;
using Neulib.Serializers;
using Neulib.Numerics;
using Neulib.Instructions;

namespace Neulib.Visuals
{
    public sealed class World : Moveable
    {
        // ----------------------------------------------------------------------------------------
        #region Properties

        public float XLo { get; set; } = 0;
        public float XHi { get; set; } = 1200f;
        public float YLo { get; set; } = 0;
        public float YHi { get; set; } = 800f;

        #endregion
        // ----------------------------------------------------------------------------------------
        #region Constructors

        public World()
        {
        }

        public World(Visual items) : base(items)
        {
        }

        public World(params Moveable[] items) : base(items)
        {
        }

        public World(Stream stream, BinarySerializer serializer) : base(stream, serializer)
        {
            XLo = stream.ReadSingle();
            XHi = stream.ReadSingle();
            YLo = stream.ReadSingle();
            YHi = stream.ReadSingle();
        }

        #endregion
        // ----------------------------------------------------------------------------------------
        #region BaseObject

        protected override void CopyFrom(object o)
        {
            base.CopyFrom(o);
            World value = o as World ?? throw new InvalidTypeException(o, nameof(World), 550727);
            XLo = value.XLo;
            XHi = value.XHi;
            YLo = value.YLo;
            YHi = value.YHi;
        }

        public override void WriteToStream(Stream stream, BinarySerializer serializer)
        {
            base.WriteToStream(stream, serializer);
            stream.WriteSingle(XLo);
            stream.WriteSingle(XHi);
            stream.WriteSingle(YLo);
            stream.WriteSingle(YHi);
        }

        #endregion
        // ----------------------------------------------------------------------------------------
        #region Visual

        public void Randomize(Random random)
        {
            Visual.Randomize(random);
        }

        public void Step(WorldSettings settings, ProgressReporter reporter, CancellationTokenSource tokenSource)
        {
            Visual.Step(settings, reporter, tokenSource);
        }

        public void AddInstructions(InstructionList instructions)
        {
            Visual.AddInstructions(instructions, Transform);
            instructions.Add(new Instruction(new Single2(XLo, YLo), InstructionEnum.Add));
            instructions.Add(new Instruction(new Single2(XHi, YHi), InstructionEnum.Rectangle));
        }

        #endregion
        // ----------------------------------------------------------------------------------------
        #region VisualWorld

        public void Learn(WorldSettings settings, ProgressReporter reporter, CancellationTokenSource tokenSource)
        {

        }

        public void Run(WorldSettings settings, ProgressReporter reporter, CancellationTokenSource tokenSource)
        {
            while (true)
            {
                tokenSource?.Token.ThrowIfCancellationRequested();
                Visual.ForEach(visual => visual.Visual.Step(settings, reporter, tokenSource), true);
            }
        }

        #endregion
    }
}