using System;
using System.Collections.Generic;
using System.Text;

namespace RacingThing.Drivers
{
    public class AggressiveDriver : Driver
    {
        public AggressiveDriver(string name, Car car)
            : base(name, car, 2.7)
        {
        }

        public override double Speed => base.Speed * 1.3;
    }
}
