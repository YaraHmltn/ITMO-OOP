using System;
using System.Collections.Generic;
using System.Text;

namespace RaceSimulator
{
    class SpeedyCamel : LandTransport
    {
        public override string Name => "SpeedyCamel";
        public override double Speed => 40;
        public override double RestInteraval => 10;

        public override double RestDuration(int i)
        {
            if (i == 1) return 5;
            if (i == 2) return 6.5;
            else return 8;
        }
    }
}
