using System;
using ClassDemo_19._01._23_;


class Program
{

    static void Main(string[] args)
    {
        //Создаём объект класса Line с использованием конструктора по умолчанию
        Line line1 = new Line();
        line1.PrintState();
        line1.Draw();

        Line line2 = new Line(15);
        line2.PrintState();
        line2.Draw();

        Line line3 = new Line(-15); // 1 - линия не может быть отрицательной длины 
        line3.PrintState();
        line3.Draw();

        int dlina = line3.Lenght; //get
        Console.WriteLine("line3 = {0}", dlina);

        Console.WriteLine("line2 = {0}", line2.Lenght); //15 //get

        line3.Lenght = 25; //set 1 -> 25 (value = 25)
        line3.PrintState();
        line3.Draw();


        line3.Lenght = -15; //set error 

        for (int i = 1; i <= 8; i++)
        {
            line1.Lenght = i;
            line1.Draw();
        }
        Console.WriteLine();

        //***********

        int xx = 255;
        Console.WriteLine(xx); //255
                               //Console.WriteLine(xx.ToString()); //255

        Console.WriteLine();
        //***********

        Console.WriteLine(line1);
        Console.WriteLine(line2);
        Console.WriteLine(line3);
        //Console.WriteLine(Line3.ToString()); //ToString()

        Console.WriteLine("Press any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмет любую клавишу
        Console.ReadKey();
    }

}
