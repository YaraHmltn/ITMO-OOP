using System;
using System.Collections.Generic;
using System.Text;

namespace RaceSimulator
{   
    public abstract class NanTransport
    {
        public abstract string Name { get; }
        public abstract double Speed { get; }
        public abstract double GetTimeRace(double distance);
    }
}
