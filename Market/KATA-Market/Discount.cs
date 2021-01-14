namespace KATA_Market
{
	public class Discount
	{
		public enum DiscountType
		{
			ByQuantityDiscount,
			ByQuantityFree,
			ByWeight, // PER POUND
		}

		public readonly DiscountType Disc;
		public readonly int Amount;
		public readonly int AmountFree;
		public readonly double Price;

		public Discount(DiscountType discType, int amount, double price)
		{
			this.Disc = discType;
			this.Amount = amount;
			this.Price = price;
		}

		/// <summary>
		/// Discount per amount
		/// </summary>
		/// <param name="amount"></param>
		/// <param name="amountFree"></param>
		public Discount(int amount, int amountFree)
		{
			this.Disc = DiscountType.ByQuantityFree;
			this.Amount = amount;
			this.AmountFree = amountFree;
		}
	}
}
