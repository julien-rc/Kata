using KATA_Market;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
	public class Tests
	{

		[SetUp]
		public void Setup()
		{
			var discountList = new List<Discount>();

			var beanDiscountByWeight = new Discount(Discount.DiscountType.ByWeight, 1, 1.99);
			var beanDiscountByQuantityBought = new Discount(Discount.DiscountType.ByQuantityDiscount, 3, 1);
			var freeDiscountByQuantityBought = new Discount(2, 1);

			discountList.Add(beanDiscountByQuantityBought);
			discountList.Add(freeDiscountByQuantityBought);
			discountList.Add(beanDiscountByWeight);

			var item = new Item(1, "beanCan", 0.65, 0, discountList);

			Market.items.Add(item);
		}

		[Test]
		public void Test_Beans()
		{
			var beanCanid = 1;
			var amount = 1;

			var expectedPrice = 0.65;

			Assert.AreEqual(expectedPrice, Market.GetPrice(beanCanid, amount));
		}
		[Test]
		public void Test_UnknownItem()
		{
			var id = 1337;
			var amount = 7;

			var expectedPrice = -1;

			Assert.AreEqual(expectedPrice, Market.GetPrice(id, amount));
		}
		[Test]
		public void Test_3_for_one()
		{
			var id = 1;
			var amount = 3;

			var expectedPrice = 1;

			Assert.AreEqual(expectedPrice, Market.GetPrice(id, amount));
		}
	}
}