using System;
using Task_class_Card;
namespace MyLibrary

{
    class Program
    {
        static void Main(string[] args)
        {
            MyConsole.StartCyrillic();

            Library lib = new Library();

            for (; ; )
            {
                int key = Menu();

                switch (key)
                {
                    case 0:
                        //для тестирования
                        Console.WriteLine("Добавлено тестирование");
                        break;
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    case 4: break;
                    case 5: break;
                    case 6:
                        return;
                }

                Console.ReadKey();
            }

            MyConsole.Pause();
        }
        static int Menu()
        {
            int key = 0;

            string[] menuString = {

            "1 - добавить карточку в каталог",
            "2 - печать каталога",
            "3 - поиск нужной книги по названию",
            "4 - поиск по фрагменту названия",
            "5 - поиск книг автора",
            "6 - завершение работы"

            };

            do
            {
                key = ConsoleInput.ReadInt();

                foreach (string str in menuString)
                {
                    Console.WriteLine(str);
                }
                Console.Write(" : ");
                key = ConsoleInput.ReadInt();

            } while (key < 0 || key >= menuString.Length);

            return key;

        }
    }
}

