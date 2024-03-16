using System;
namespace SimpleDerived
{
    class ChemicalEngineer : Engineer
    {
        public ChemicalEngineer(string name, float billingRate) : base(name, billingRate)
        {
            Console.WriteLine("constructor " + TypeName());
        }

        public override string TypeName()
        {
            return "ChemicalEngineer";
        }
    }
}

