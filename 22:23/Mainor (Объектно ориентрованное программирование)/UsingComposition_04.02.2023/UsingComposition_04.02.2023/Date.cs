using System; // Объявление пространства имен

namespace UsingComposition // Объявление простого класса, который представляет дату
{
    class Date
    {
        DateTime date; // Объявление приватной переменной, которая хранит дату

        public Date(int month, int day, int year) // Объявление конструктора класса, который создает экземпляр класса Date на основе переданных значений для месяца, дня и года
        {
            // Использование конструктора класса DateTime для создания объекта DateTime на основе переданных значений
            // Проверка на возможные исключения
            try
            {
                date = new DateTime(year, month, day);
            }
            catch (Exception exc)
            {
                // Вывод сообщения об исключении в консоль
                Console.WriteLine(exc.Message);
            }
        }

        // Переопределение метода ToString, который возвращает строковое представление экземпляра класса Date
        public override string ToString()
        {
            //return date.ToLongDateString();
            // Возврат краткой строки даты
            return date.ToShortDateString();
        }
    }
}
