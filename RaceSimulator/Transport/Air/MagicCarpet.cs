using System;
using System.Collections.Generic;
using System.Text;

namespace RaceSimulator
{
    class MagicCarpet : AirTransport
    {
        public override string Name => "MagicCarper";
        public override double Speed => 10;
        public override double DistanceReducer(double distance)
        {
            if (distance < 1000) return distance;
            if (distance >= 1000 && distance < 5000) return distance * 0.97;
            if (distance >= 5000 && distance < 10000) return distance * 0.90;
            else return distance * 0.95;

        }
    }
}
