using System;
using System.Collections.Generic;
using System.Text;

namespace RaceSimulator
{
    public class Mortar : AirTransport
    {
        public override string Name => "Mortar";
        public override double Speed => 8;
        public override double DistanceReducer(double distance)
        {
            return distance * 0.94;
        }
    }
}
