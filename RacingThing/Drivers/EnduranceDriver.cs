using System;
using System.Collections.Generic;
using System.Text;

namespace RacingThing.Drivers
{
    public class EnduranceDriver : Driver
    {
        public EnduranceDriver(string name, Car car)
            : base(name, car, 1.5)
        {

        }
    }
}
