using System;
using System.Collections.Generic;
using System.Text;

namespace RacingThing.Tyres
{
    public class UltrasoftTyre : Tyre
    {
        private double degradation;

        public UltrasoftTyre(double hardness, double grip)
            : base(hardness)
        {
            this.Grip = grip;
        }

        public double Grip { get; }

        public override string Name => "Ultrasoft";

        public override double Degradation
        {
            get => this.degradation;
            protected set
            {
                if (value < 30)
                {
                    throw new ArgumentException(BLOWN_TYRE_ERROR);
                }
                this.degradation = value;
            }
        }
    }
}
