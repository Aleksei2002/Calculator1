using System;

namespace Task_ClassRectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rect1 = new Rectangle();
            Console.WriteLine(
                "Length = {0}, Width = {1}",
                rect1.Length, rect1.Width
                );

            Rectangle rect2 = new Rectangle(25, 50);
            Console.WriteLine(
                "Length = {0}, Width = {1}",
                rect2.Length, rect2.Width
                );

            Rectangle rect3 = new Rectangle(-5, -2);
            Console.WriteLine(
                "Length = {0}, Width = {1}",
                rect3.Length, rect3.Width
                );

            rect3 = new Rectangle(-5, -2);
            Console.WriteLine(
                "Length = {0}, Width = {1}",
                rect3.Length, rect3.Width
                );

            rect3 = new Rectangle(-5, -2);
            Console.WriteLine(
                "Length = {0}, Width = {1}",
                rect3.Length, rect3.Width
                );

        //======================================================================

            Console.WriteLine("rect1.Area() = {0}, rect1.AreaRect = {1}",
                rect1.Area(), rect1.AreaRect);

            Console.WriteLine("rect2.Area() = {0}, rect2.AreaRect = {1}",
                rect2.Area(), rect2.AreaRect);

        //======================================================================

            rect1.DrawFill();
            rect2.DrawFill();

            rect1.Draw();
            rect2.Draw();

            //======================================================================

            Console.WriteLine();
            Console.WriteLine(rect1); //ToString()
            Console.WriteLine(rect2); //ToString()

            //Console.WriteLine(rect2.ToString());

            Console.ReadKey();
        }
    }
}

