using System;
namespace NO_26_Aleksei_Maloskin
{
    public class Circle : Shape
    {
        private double radius;

        public Circle()
        {
            radius = 1.0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(double radius, string color, bool filled) : base(color, filled)
        {
            this.radius = radius;
        }

        public double GetRadius()
        {
            return radius;
        }

        public void SetRadius(double radius)
        {
            this.radius = radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override string ToString()
        {
            return $"Circle\n[color={GetColor()},\n filled={IsFilled()},\n radius={radius}]";
        }
    }
}

