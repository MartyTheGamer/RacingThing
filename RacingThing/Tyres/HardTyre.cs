using System;
using System.Collections.Generic;
using System.Text;

namespace RacingThing.Tyres
{
    public class HardTyre : Tyre
    {
        public HardTyre(double hardness)
            : base(hardness)
        {
        }

        public override string Name => "Hard";
    }
}
