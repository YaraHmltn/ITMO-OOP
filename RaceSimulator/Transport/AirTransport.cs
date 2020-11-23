using System;
using System.Collections.Generic;
using System.Text;

namespace RaceSimulator
{
    public abstract class AirTransport : NanTransport
    {
        public abstract double DistanceReducer(double distance);

        public override double GetTimeRace(double distance)
        {
            return DistanceReducer(distance) / Speed;
        }
    }
}
