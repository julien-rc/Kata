using System.Collections.Generic;
using System.Linq;

namespace KATA_Market
{
	/// <summary>
	/// one can = $0.65
	/// 3 for #1
	/// $1.99 / pound
	/// 2 --> 1 free
	/// </summary>
	public static class Market
	{
		// use another DS
		public static List<Item> items = new List<Item>();

		public static double GetPrice(int id, int amount)
		{
			var item = items.FirstOrDefault(x => x.Id == id);

			if (item == null)
			{
				return -1;
			}

			return item.Price;
		}
	}
}
