using System;
namespace SimpleDerived
{
    class Engineer
    {
        private string name;
        protected float billingRate; //protected - статус как у politepryvate. Они закрыты

        public Engineer()
        {

        }

        public Engineer(string name, float billingRate)
        {
            this.name = name;
            this.billingRate = billingRate;
            Console.WriteLine("\nconstructor " + "Engineer");
        }

        ~Engineer()
        {
            Console.WriteLine("Destructor ~Engineer\n");
        }

        //public float CalculateChartge(float hour)

        public virtual float CalculateChartge(float hour)
        {
            return billingRate * hour;
        }
        //public string TypeName()

        public virtual string TypeName() //virtual - переопределяет
        {
            return "Engineer";
        }
    }
}
