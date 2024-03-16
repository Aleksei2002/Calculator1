using System;
using System.Text;


namespace MyLibrary
{
    class MyConsole
    {
        public static void Pause(string str = "ENG")
        {
            if (str == "ENG")
            {
                Console.WriteLine("Press any key to continue...");
                //
                //pause - задержка экрана
                //- пока пользователь не нажмет любую клавишу
                Console.WriteLine();
            }
            else if (str == "RUS")
            {
                Console.Write("\n\n Нажми любую клавишу для продолжения...");
            }
            Console.ReadKey();
        }

        public static void StartCyrillic()
        {

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.GetEncoding(65001);


        }
    }
}