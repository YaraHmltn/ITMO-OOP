using System;
using System.Collections.Generic;
using System.Text;

namespace RaceSimulator
{
    class BactrianCamel : LandTransport
    {
        public override string Name => "BactrianCame";
        public override double Speed => 15;
        public override double RestInteraval => 30;

        public override double RestDuration(int i)
        {
            if (i == 1) return 5;
            else return 10;
        }
    }
}
