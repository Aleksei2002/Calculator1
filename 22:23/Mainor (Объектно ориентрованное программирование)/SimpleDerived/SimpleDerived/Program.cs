using System;
using SimpleDerived;

class Program
{

    static void Main(string[] args)
    {
        Engineer engineer = new Engineer("Petroff", 25f);
        Console.WriteLine("Name is: {0} CalculateChartge: {1}",
            engineer.TypeName(), engineer.CalculateChartge(40.0f)); //40.0 -
                                                                    //double, он не был прописал, но если вставить "f", то ошибка пропадет

        CivilEngineer cEngineer = new CivilEngineer("Ivanov", 100f);
        Console.WriteLine("Name is: {0} CalculateChartge: {1}",
            cEngineer.TypeName(), cEngineer.CalculateChartge(0.75f));

        Console.WriteLine();

        ////////////////////////////////////////////////////////////////////
        ///
        Engineer[] arrayE = new Engineer[2];
        arrayE[0] = new Engineer("Popov", 25f);
        arrayE[1] = new CivilEngineer("Petrov", 100f);

        /*
        Ошибка из-за того, что все скрываемые методы оператором new определяется
        по базовому типу Engineer[]arrayE.
        */

        for(int i = 0; i<arrayE.Length; i++)
        {
            Console.WriteLine("Name is: {0} CalculateChartge: {1}",
                arrayE[i].TypeName(), arrayE[i].CalculateChartge(0.75f));
        }

        Console.WriteLine("Press any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмет любую клавишу
        Console.ReadKey();
    }

}