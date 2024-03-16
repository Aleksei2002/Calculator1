using ClassPerson;

namespace class_Person_Person_Praktika_2
{
    class PersonList
    {
        List<Person> list; // ссылка на объект класса List<Person>

        public PersonList()
        {
            //Создаём объект класса List<Person>
            list = new List<Person>();
        }

        //отражает текущее количество персон в списке.
        public int CountPerson
        {
            get { return list.Count; }
        }

        //метод заносит данные в динамический массив.
        public bool Add(Person person)
        {
            //foreach(Person p in list)
            //{
            //    if (p.Equals(person))
            //    {
            //        return false;
            //    }
            //}

            if (list.Contains(person))
            {
                Console.WriteLine(" !!!! {0}", person);
                return false;
            }

            list.Add(person);

            return true;
        }

        //метод печатает содержимое динамического массива
        public void PrintListPerson()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("List is Empty!");
            }
            else
            {
                foreach (Person person in list)
                {
                    Console.WriteLine(person); //person.ToString();
                }
                Console.WriteLine();

            }
        }

        public void Sort()
        {
            list.Sort();
        }


    }
}
