using System;
using System.Collections.Generic;
using System.Text;

namespace RacingThing
{
    public abstract class Tyre
    {
        public const string BLOWN_TYRE_ERROR = "Blown tyre";

        private double degradation;
        private double hardness;

        protected Tyre(double hardness)
        {
            this.Hardness = hardness;
            this.Degradation = 100;
        }
        public abstract string Name { get; }

        public double Hardness { get; }

        public virtual double Degradation
        {
            get => this.degradation;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(BLOWN_TYRE_ERROR);
                }
                this.degradation = value;
            }
        }

        public virtual void ReduceDegradation()
        {
            this.Degradation -= this.Hardness;
        }
    }
}

