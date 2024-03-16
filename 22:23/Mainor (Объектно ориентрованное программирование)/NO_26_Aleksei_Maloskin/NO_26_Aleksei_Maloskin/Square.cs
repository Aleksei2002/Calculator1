using System;
namespace NO_26_Aleksei_Maloskin
{
    public class Square : Rectangle
    {
        public Square() : base()
        {
        }

        public Square(double side) : base(side, side)
        {
        }

        public Square(double side, string color, bool filled) : base(side, side, color, filled)
        {
        }

        public double GetSide()
        {
            return GetWidth();
        }

        public void SetSide(double side)
        {
            SetWidth(side);
            //SetHeight(side);
        }

        public override string ToString()
        {
            return $"Square \n[rectangle \n[Shape[color={GetColor()}, filled={IsFilled()}], width={GetWidth()},";
        }
    }

}

