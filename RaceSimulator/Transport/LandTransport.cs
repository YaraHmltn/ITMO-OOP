using System;
using System.Collections.Generic;
using System.Text;

namespace RaceSimulator
{
    public abstract class LandTransport : NanTransport
    {
        public abstract double RestDuration(int i);
        public abstract double RestInteraval { get; }

        public override double GetTimeRace(double distance)
        {
            int Rests = (int)(distance / Speed / RestInteraval);
            double RestTime = 0;
            for (int i = 0; i < Rests; ++i)
                RestTime += RestDuration(i);
            return distance / Speed + RestTime;
        }
    }
}
