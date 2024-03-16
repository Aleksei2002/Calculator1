using System;
namespace Travel_Agency
{
	class SuperTour : Tour
	{
		double discount;
		int countPeopleForDiscount;

		public SuperTour(string type, double duration, double priceOnePer, int maxNumberPeople) :
			base(type, duration, priceOnePer, maxNumberPeople)
		{
			this.discount = discount;
			if (countPeopleForDiscount > maxNumberPeople)
			{
				this.countPeopleForDiscount = maxNumberPeople;
			}
			else {
				this.countPeopleForDiscount = countPeopleForDiscount;
			}
        }
		public double Discount;
	}
}

