using System;
using System.Collections.Generic;
using System.Text;

namespace Task_ClassRectangle
{
    class Rectangle
    {

        //По умолчанию поля класса private
        int length;
        int width;

        public int Length
        {
            get { return this.length; }
        }

        public int Width
        {
            get { return this.width; }
        }

        //1
        /*
        
        public Rectangle(){
            this.length = 10;
            this.width = 15;
        }

        */

        //======================================================================

        /*
         
        В примере определены 2 конструктора:
        public Rectangle() {}
        и
        public Rectangle(int length, int width) {},
        которые выполняют однотипные действия - устанавливают значения полей length и width.

        Мы можем не дублировать функциональность конструкторов, а обращаться
        из одного конструктора к другому через ключевое слово this,
        передавая нужные значения для параметров:

        */

        //======================================================================

        /*
         
        //2
        Public Rectangle() : this(10, 15)
        {
        }
        public Rectangle (int length, int width)
        {
            if (length > 0 && width > 0){
                this.length = length;
                this.width = width;
            }
            else
            {
                this.length = 10;
                this.width = 15;
            }
        }

        //3 Объединим два конструктора в один,
        используя в входных параметрах значения по умолчанию
        */

        public Rectangle(int length = 10, int width = 15)
        {
            if (length > 0 && width > 0)
            {
                this.length = length;
                this.width = width;
            }
            else
            {
                this.length = 10;
                this.width = 15;
            }
        }

        public int Area()
        {
            return this.length * this.width;
        }
        //или вычисление площади можно реализовать, как свойства класса
        public int AreaRect
        {
            get { return this.length * this.width; }
        }

        public void DrawFill()
        {
            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; i <= length; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }//end DrawFill

        public void Draw()
        {
            for(int i = 1; i <= length; i++)
            {
                if (i == 1 || i == length)
                {
                    for (int j = 1; j <= width; j++)
                    {
                        Console.Write("#");
                    }
                }
                else
                {
                    for (int j = 1; j <= width; j++)
                    {
                        if (j == 1 || j == width)
                        {
                            Console.Write("#");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        } // end Draw

        //переопределение метода ToString() базового класса Object
        public override string ToString()
        {
            return String.Format(
                "Rectangle: {0,4} x {1,4}",
                this.length, this.width);
        }
    }
}