using System;
using Practic_class_person;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Count persons = {0}", Person.Count);

        Person person1 = new Person("Petrov", "Anton", "50010080831");

        Console.WriteLine(person1);

        string stroka = "";
        stroka = person1.lastName; //get
        Console.WriteLine(stroka);

        Console.WriteLine(
            "{0,-21} {1,-21} {2,-12}",
            person1.lastName, person1.firstName, person1.ID);

        public int ComputeAge()
        {
            int YY = 0;

            string year = IDictionary.substring(1, 2);
            if (ID[0] == '5' || ID[0] == '6')
            {
                year = "20" + year;
            }
            else if (ID[0] == '3' || ID[0] == '4')
            {
                year = '19' + year;
            }
            try
            {
                YY = Int32.Parse(Year);

            }catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }

        Console.WriteLine("Press any key to continue...");
        //pause - задержка экрана - пока пользователь не нажмет любую клавишу
        Console.ReadKey();
    }

}