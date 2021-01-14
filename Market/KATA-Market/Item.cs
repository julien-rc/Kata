using System.Collections.Generic;

namespace KATA_Market
{

	public class Item
	{
		public int Id;
		public string Name;
		public double Price;
		//public double PricePerPound;
		public List<Discount> Disconts;

		public Item(int id, string name, double price, int pricepp, List<Discount> discs)
		{
			this.Id = id;
			this.Name = name;
			this.Price = price;
			//this.PricePerPound = pricepp;
			this.Disconts = discs;
		}
	}

}
