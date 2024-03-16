using System;
namespace SimpleDerived
{
	class CivilEngineer : Engineer // является наследником класа "Engineer"
    {
		public CivilEngineer(string name, float billingRate) :
			base(name, billingRate)
		{
			Console.WriteLine("constructor" + TypeName());
		}

		~CivilEngineer()
		{
			Console.WriteLine("Destructor " + TypeName());
		}

        //new public float calculateChartge(float hour)

        public override float CalculateChartge(float hour)
        {
			if (hour < 1)
			{
				hour = 1;
			}
			return billingRate * hour;
		}
        //new public string TypeName()

        public override string TypeName()
        {
			return "CivilEngineer";
		}
    }
}

