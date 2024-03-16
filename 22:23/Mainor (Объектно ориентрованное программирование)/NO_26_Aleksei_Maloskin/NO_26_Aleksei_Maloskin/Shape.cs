using System;
namespace NO_26_Aleksei_Maloskin
{
	public abstract class Shape
	{
		protected string color = "Red";
		protected bool filled = true;

		public Shape() { }

		public Shape(string color, bool filled)
		{
			this.color = color;
			this.filled = filled;
		}

		public string GetColor()
		{
			return color;
		}

		public bool IsFilled()
		{
			return filled;
		}

		public void SetFilled(bool filled)
		{
			this.filled = filled;
		}

		public abstract double GetArea();

		public abstract double GetPerimeter();

        public override string ToString()
        {
			return $"Shape[color={color}, filled={filled}]";
        }
    }
}

