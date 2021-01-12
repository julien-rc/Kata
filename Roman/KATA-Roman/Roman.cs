using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KATA_Roman
{
	public static class Roman
	{
		private static Dictionary<int, string> SymbolValue;
		static Roman()
		{
			SymbolValue = new Dictionary<int, string>();
			SymbolValue.Add(1000, "M");
			SymbolValue.Add(900, "CM");
			SymbolValue.Add(500, "D");
			SymbolValue.Add(400, "CD");
			SymbolValue.Add(100, "C");
			SymbolValue.Add(90, "XC");
			SymbolValue.Add(50, "L");
			SymbolValue.Add(40, "XL");
			SymbolValue.Add(10, "X");
			SymbolValue.Add(9, "IX");
			SymbolValue.Add(5, "V");
			SymbolValue.Add(4, "IV");
			SymbolValue.Add(1, "I");
		}

		public static string ToRoman(int nb)
		{
			// Handle 0 --> no 0 in roman
			// Handle > 3999 --> max value
			if (nb == 0 || nb >= 4000)
			{
				return ":(";
			}

			var sb = new StringBuilder();

			for (int i = 0; i < SymbolValue.Count; i++)
			{
				int t = (int)SymbolValue.Keys.ElementAt(i);
				//Console.WriteLine("------------ Trying with " + t);
				while (nb >= t)
				{
					//Console.WriteLine("nb --> " + nb);
					nb -= t;
					//Console.WriteLine("new nb --> " + nb);
					var newChar = SymbolValue.Values.ElementAt(i);
					//Console.WriteLine("------------ Adding " + new_char);

					sb.Append(newChar);
				}
			}

			return sb.ToString();
		}

	}
}