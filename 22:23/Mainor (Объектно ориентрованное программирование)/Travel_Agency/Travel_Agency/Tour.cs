using System;
namespace Travel_Agency
{
    class Tour
    {
        /*
		 
		 */
        protected string type;
        protected double duration;
        protected double priceOnePer;
        protected int maxNumberPeople;

        public Tour(string type, double duration, double priceOnePer, int maxNumberPeople)
        {
            this.type = type;
            this.duration = duration;
            this.priceOnePer = priceOnePer;
            this.maxNumberPeople = maxNumberPeople;
        }

        //запрос типа пакета
        public string Type { get { return this.type; } }

        //запрос длительности путешествии
        public double Duration { get { return this.duration; } }

        //запрос стоимости путешествии для одного участника

        //возможность установить стоимость путешествия для одного путешественика
        public double PriceOnePer {
            set { this.priceOnePer = value; }
            get { return this.priceOnePer; }
        }

        //запрос стоимости путешествия для одного участника

        //запрос максимального количества участников в группе
        public int MaxNumberPeople { get { return this.MaxNumberPeople; } }

        //метод, который получает в качестве входного аргумента количество людей и проверяет, подходит ли данный пакет для группы с таким количеством людей
        public bool PeopleForGroup(int numberPeople) {
            return numberPeople <= this.MaxNumberPeople;
        }

        public virtual double PriceForGroup(int numberPeople) {
            if (PeopleForGroup(numberPeople) == false)
                return -1;
            return this.priceOnePer * numberPeople;
        }

        /*
         возможность представить информацию о пакете путешествия в текстовом виде
         (переопределить метод ToString()); eсли длительность поездки больше, чем 24
         часа, то длительность поездки отобразить в количестве полных суток.
         */

        public override string ToString()
        {
            return string.Format("{0,-25} duration: {1,3} priceOnePer:{2,6:f2} maxNumberPeople: {3,3}",
                type,
                (duration > 24 ? (int)Math.Ceiling(duration / 24) : 1),
                priceOnePer,
                maxNumberPeople);
        }
    }
}