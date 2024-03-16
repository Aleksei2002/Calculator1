using System;
namespace Abstract_Class_Figure
{
	abstract class Figure
	{
        protected double length;
        protected double width;

        //public Figure() : this(0, 0)
        //{

        //}

        public Figure(double length = 0, double width = 0)
        {
            if (length > 0 && width > 0)
            {
                this.length = length;
                this.width = width;
            }
        }

        public double Length { get { return length; } }

        public double Width { get { return width; } }

        public override string ToString()
        {
            return String.Format("Figure: {0}*{1}", length, width);
        }

        abstract public double Area();

    }
}

