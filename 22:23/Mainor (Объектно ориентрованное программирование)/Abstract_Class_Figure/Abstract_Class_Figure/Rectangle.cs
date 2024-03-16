using System;
namespace Abstract_Class_Figure
{
	class Rectangle : Figure
	{
		public Rectangle(double length = 1, double width = 1) : base(length, width)
		{
			if (this.Length > 50)
			{
				this.length = 50;
			}

			if (this.width > 50)
			{
				this.width = 50;
			}

			if (length < 0 || width > 0)
			{
				this.length = 1;
				this.width = 1;
			}

			if (length < 0) {this.length = 1; }
			if (width < 0) { this.width = 1; }
		}
		public override double Area()
		{
			return this.length * this.Width;
		}
	}
}

