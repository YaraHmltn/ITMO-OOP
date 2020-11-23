using System;
using System.Collections.Generic;
using System.Text;

namespace RaceSimulator
{
    class Broom : AirTransport
    {
        public override string Name => "Broom";
        public override double Speed => 20;

        public override  double DistanceReducer(double distance)
        {
            return  distance * (1-(int)(distance / 1000) * 0.01);
        }

    }
}
