using System;
using System.Collections.Generic;
using System.Text;
using Task_class_Card;

namespace Task_class_Card
{
    class Card : IComparable //класс Card реализует(имплементирует)
                             //интерфейс IComparable
                             //задаём "правила" сравнения/сортировки объектов
    {
        string author;
        string title;
        int number;

        public string Author {   get { return this.author; }        }

        public string Title {    get { return this.title; }        }

        public int Number { get { return this.number; }            }
        public Card():this("unknow", "unknow", 0)
        {
        }
        public Card(string author,string title, int number)   {
            SetInfo(author,title, number);
        }

        public void SetInfo(string author, string title, int number) {
            this.author = author;
            this.title = title;
            if (number >= 0) {
                this.number = number;
            } else  {
                Console.WriteLine("Error value number = {}", number);
            }
        }

        public void Info()
        {
            Console.WriteLine(
                "author: {0,-15}, title: {1,-15} count: {2,3}",
                this.author, this.title, this.number);
        }

        public override string ToString()
        {
            return String.Format("{0,-15} {1,-15} {2,3}",
                this.author, this.title, this.number);
        }

        //задаём "правила" сравнения/сортировки объектов
        public int CompareTo(object obj)
        {
            Card temp = (Card)obj;

            return this.Author.CompareTo(temp.Author);
            // return this.Title.CompareTo(temp.Title);
            //return this.Number.CompareTo(temp.Number);
        }



        



    }
}
