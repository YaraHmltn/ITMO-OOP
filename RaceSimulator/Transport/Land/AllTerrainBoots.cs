using System;
using System.Collections.Generic;
using System.Text;

namespace RaceSimulator
{
    class AllTerrainBoots : LandTransport
    {
        public override string Name => "AllTerrainBoots";
        public override double Speed => 6;
        public override double RestInteraval => 60;

        public override double RestDuration(int i)
        {
            if (i == 1) return 10;
            else return 5;
        }
    }
}
