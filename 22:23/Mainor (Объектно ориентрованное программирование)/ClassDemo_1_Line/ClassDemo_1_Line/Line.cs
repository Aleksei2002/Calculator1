using System;



namespace ClassDemo_19._01._23_
{
    class Line //: Object // - по умолчанию любой класс является наследником класса Object 
    {
        // Обьявляем переменную класса/поля класса -
        // все поля класса должны быть закрытого типа
        //private int lenght;

        int lenght; // - если модификатор доступа не указан явно,
                    // то по умолчанию переменная получает статус privet 

        //properties - свойства класса
        // - открыто для чтения (get)
        // - санкционное изменение значения закрытой переменной (set)

        public int Lenght
        {
            get { return lenght; }

            //set { this.lenght = value; }
            set
            {
                if (value >= 0 && value <= 50)
                {
                    //изменяем значение закрытой переменной только,
                    // если новое значение >= 0 или <= 50
                    lenght = value;
                }
                else
                {
                    Console.WriteLine("Error: Lenght < 0 || Lenght > 50; Lenght = {0}", lenght);
                }
            }
        }

        //Constructor

        //Переопределим конструктор по умолчанию

        public Line()
        {
            lenght = 1;
            Console.WriteLine("Constructor");
        }

        //public Line(int lan)
        //{
        //	lenght = lan;
        //	Console.WriteLine("Constructor");
        //}

        public Line(int lenght)
        {
            //if (lenght > 0)     //контролируем, чтобы линия была нуля
            //{
            //    this.lenght = lenght;
            //}
            //else
            //{
            //    this.lenght = 1; // или так this.lenght 
            //}
            this.Lenght = lenght; //set
            Console.WriteLine("Constructor");
        }


        //функциональность класса - открытые методы
        public void PrintState()
        {
            Console.WriteLine("Line: lenght = {0,3}", lenght);
        }


        public void Draw()
        {
            for (int i = 1; i <= lenght; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        // Переопределение метода ToString() базового класса Object

        public override string ToString()
        {
            return String.Format("Line: {0,3}", lenght);
        }

        // destruction
        ~Line()
        {
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine("destructor");
        }
    }
}

