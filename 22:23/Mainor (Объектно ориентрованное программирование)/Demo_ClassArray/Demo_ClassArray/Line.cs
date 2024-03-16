using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo_1_Line
{
    class Line //: Object // - по умолчанию любой класс является наследником класса Object
    {
        //объявляем переменную класса/поля класса -
        //все поля класса должны быть закрытого типа (private)
        //private int length; 

        int length; // - если модификатор доступа не указан явно,
                    // то по умолчанию переменная получает статус private

        //properties - свойства класса
        // - открыто для чтения (get)
        // - санкционное изменение значения закрытой переменной (set)

        public int Length
        {
            get { return length; }

            // set { length = value; }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    //изменяем значение закрытой переменной только,
                    //если новое значение >=0 И <=50
                    length = value;
                }
                else
                {
                    Console.WriteLine("Error: Length<0 || Length>50; Length = {0}", length);
                }
            }

        }

        //constructor

        //переопределим конструктор по умолчанию
        public Line()
        {
            length = 1;
            Console.WriteLine("Constructor");
        }


        //public Line(int len)
        //{
        //    length = len;
        //    Console.WriteLine("Constructor");
        //}

        public Line(int length)
        {
            //if (length > 0)
            //{
            //    this.length = length;
            //}
            //else
            //{
            //     this.length = 1;
            //}

            this.Length = length; //set

            Console.WriteLine("Constructor");
        }

        //функциональность класса - открытые методы
        public void PrintState()
        {
            Console.WriteLine("Line: length = {0,3}", length);
        }

        public void Draw()
        {
            for (int i = 1; i <= length; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // переопределение метода ToString() базового класса Object

        public override string ToString()
        {
            //return String.Format("Line: {0,3}", length);

            //C# ver 7.0

            return String.Format("{0}: {1,3}", nameof(length), length);
        }

        //Задаем "Правила" сравнения/сортировки объектов

        public int CompareTo(object obj)
        {
            //Line line = obj as Line;
            Line line = (Line)obj;

            if (this.length == line.length)
                return 0;
            if (this.length > line.length)
                return -1;
        }

        //destructor
        ~Line()
        {
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("destructor");
        }

    }
}