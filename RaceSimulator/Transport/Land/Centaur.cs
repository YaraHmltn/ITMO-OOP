using System;
using System.Collections.Generic;
using System.Text;

namespace RaceSimulator
{
    class Centaur : LandTransport
    {
        public override string Name => "Centaur";
        public override double Speed => 20;
        public override double RestInteraval => 8;

        public override double RestDuration(int i)
        {
            return 2;
        }
    }
}
