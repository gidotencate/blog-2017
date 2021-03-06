﻿using BuilderWithInheritance.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderWithInheritance.CuriousGenerics
{
    class LocalGameBuilder : GameBuilder<LocalGame, LocalGameBuilder>
    {
        private int _aiStrength = 3;

        //protected override LocalGameBuilder BuilderInstance => this;

        public LocalGameBuilder AiStrength(int aiStrength)
        {
            _aiStrength = aiStrength;
            return this;
        }

        //now only LocalGame can be built by LocalGameBuilder
        public override LocalGame Build() =>
            new LocalGame(_aiStrength, _boardSize, _level);
    }
}
