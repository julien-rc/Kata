using System.Linq;
using System.Text;

namespace KATA_FooBarQix
{
	public static class FooBarQix
	{
		public static string DoFullFooBarQix()
		{
			StringBuilder sb = new StringBuilder();

			for (int i = 1; i <= 100; i++)
			{
				sb.AppendLine(DoFooBarQix(i).ToString());
			}

			return sb.ToString();
		}

		public static string DoFooBarQix(int nb)
		{
			if (nb <= 0 || nb > 100)
			{
				return ":(";
			}

			string result = string.Empty;
			string nbString = nb.ToString();
			StringBuilder sb = new StringBuilder();
			var charArray = nbString.ToCharArray();

			if (nb % 3 == 0)
			{
				sb.Append("Foo");
			}
			if (nb % 5 == 0)
			{
				sb.Append("Bar");
			}
			if (nb % 7 == 0)
			{
				sb.Append("Qix");
			}


			foreach (var c in charArray)
			{
				if (c == '3')
				{
					sb.Append("Foo");
				}
				else if (c == '5')
				{
					sb.Append("Bar");
				}
				else if (c == '7')
				{
					sb.Append("Qix");
				}
			}

			result = sb.ToString();

			if (result == string.Empty)
			{
				return nb.ToString();
			}
			return result;
		}


		private static string DoFooBarQixWithout53Rule(int nb)
		{
			if (nb <= 0 || nb > 100)
			{
				return ":(";
			}

			string result = string.Empty;
			string nbString = nb.ToString();
			StringBuilder sb = new StringBuilder();

			if (nb % 3 == 0)
			{
				sb.Append("Foo");
			}
			if (nb % 5 == 0)
			{
				sb.Append("Bar");
			}
			if (nb % 7 == 0)
			{
				sb.Append("Qix");
			}

			result = sb.ToString();
			var charArray = nbString.ToCharArray();

			var nbThree = nbString.Count(x => (x == '3'));
			var nbFive = nbString.Count(x => (x == '5'));
			var nbSeven = nbString.Count(x => (x == '7'));

			result += string.Concat(Enumerable.Repeat("Foo", nbThree));
			result += string.Concat(Enumerable.Repeat("Bar", nbFive));
			result += string.Concat(Enumerable.Repeat("Qix", nbSeven));

			if (result == string.Empty)
			{
				return nb.ToString();
			}
			return result;
		}
	}
}
