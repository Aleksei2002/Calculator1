using System; // Объявление пространства имен

namespace UsingComposition // Объявление класса Employee, который представляет сотрудника
{
    class Employee
    {
        // Объявление приватных переменных, которые представляют имя, фамилию, дату рождения и дату приема на работу
        string firstName;
        string lastName;
        Date birthDate; //reference to a Date object // ссылка на объект типа Date
        Date hireDate;  //reference to a Date object // ссылка на объект типа Date

        // Объявление конструктора класса, который создает экземпляр класса Employee на основе переданных значений
        public Employee(
          string firstName, string lastName,
          int bDay, int bMonth, int bYear,
          int hDay, int hMonth, int hYear)
        {
            // Присвоение значений переданных параметров переменным
            this.firstName = firstName;
            this.lastName = lastName;

            // Создание объектов типа Date на основе переданных значений и присвоение ссылок на эти объекты переменным birthDate и hireDate
            birthDate = new Date(bMonth, bDay, bYear);
            hireDate = new Date(hMonth, hDay, hYear);
        }

        // Переопределение метода ToString, который возвращает строковое представление экземпляра класса Employee
        public override string ToString()
        {
            // Форматирование строки вывода с использованием значений переменных lastName, firstName, hireDate и birthDate
            return String.Format(
         "{0,-15} {1,-15} Hired :{2} Birthday :{3}",
          lastName, firstName, hireDate, birthDate);
        }
    }
}
