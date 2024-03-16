using System;
using ClassPerson;

namespace class_Person_Person_Praktika_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Vasja", "Pupkin", "39905055566");
            Person person2 = new Person("Lena", "Petrova", "49005055571");
            Person person3 = new Person("Jelena", "Ivanova", "400005050071");

            //Создаём объект класса PersonList
            PersonList personList = new PersonList();

            personList.PrintListPerson();  //"List is Empty!"

            personList.Add(person1);
            personList.Add(person2);
            personList.Add(person3);
            personList.Add(new Person("Anton", "Antonov", "32009067010"));
            personList.Add(new Person("Boris", "Yakushev", "32009107110"));

            // текущее количество персон в списке.
            Console.WriteLine(
                "personList.CountPerson = {0}", personList.CountPerson);

            personList.PrintListPerson();

            bool result = personList.Add(person3);//!!!! error -> false
            Console.WriteLine(result);  //false

            //  Console.WriteLine(person1);        //ToString()
            //  Console.WriteLine(person1.IdKod); //get

            // текущее количество персон в списке.
            Console.WriteLine(
                "personList.CountPerson = {0}", personList.CountPerson);

            personList.Sort();

            personList.PrintListPerson();

            Console.WriteLine("Press any key to continue...");
            //pause - задержка экрана - пока пользователь не нажмет любую клавишу
            Console.ReadKey();
        }
    }
}
