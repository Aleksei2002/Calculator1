using System;
namespace Practic_class_person;

public class Person
{
	public Person()
	{ }
		//Фамилия; Имя; Идентификационный номер персоны(ID - kod)
		public string lastName;
		public string firstName;
		public string ID;

		static int count;

		public static int Count
		{
			get { return count; }
		}

		//Конструктор с входными параметрами.
		public Person(string lastName, string firstName, string ID)
		{
			if(CheckString(lastName) && CheckString(firstName) && CheckString(ID))
			{
				this.lastName = lastName;
				this.firstName = firstName;
				this.ID = ID;
			}
			else
			{
                //exception - аваоийная ситуация
                //throw new Exception();
                if (CheckString(lastName) && CheckString(firstName) && CheckString(ID))
                this.lastName = "UNKNOWN";
				this.firstName = "UNKNOWN";
				this.ID = "UNKNOWN";

            }
        }

		bool CheckString(string str)
		{
			if(str == "" || str == null)
			{
				return false;
			}
			return true;

		}

		//Класс имеет свойства(чтения) для всех полей


		//Переопределить метод ToString()
}

