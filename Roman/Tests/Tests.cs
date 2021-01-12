using KATA_Roman;
using NUnit.Framework;

namespace Tests
{
	public class Tests
	{
		[Test]
		public void Test_1()
		{
			int input = 1;
			string expected = "I";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_2()
		{
			int input = 2;
			string expected = "II";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_3()
		{
			int input = 3;
			string expected = "III";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_4()
		{
			int input = 4;
			string expected = "IV";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_5()
		{
			int input = 5;
			string expected = "V";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_6()
		{
			int input = 6;
			string expected = "VI";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_8()
		{
			int input = 8;
			string expected = "VIII";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_9()
		{
			int input = 9;
			string expected = "IX";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_10()
		{
			int input = 10;
			string expected = "X";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_29()
		{
			int input = 29;
			string expected = "XXIX";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_30()
		{
			int input = 30;
			string expected = "XXX";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_40()
		{
			int input = 40;
			string expected = "XL";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_50()
		{
			int input = 50;
			string expected = "L";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_90()
		{
			int input = 90;
			string expected = "XC";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_100()
		{
			int input = 100;
			string expected = "C";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_200()
		{
			int input = 200;
			string expected = "CC";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_500()
		{
			int input = 500;
			string expected = "D";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_800()
		{
			int input = 800;
			string expected = "DCCC";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_888()
		{
			int input = 888;
			string expected = "DCCCLXXXVIII";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_1000()
		{
			int input = 1000;
			string expected = "M";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_1990()
		{
			int input = 1990;
			string expected = "MCMXC";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_3000()
		{
			int input = 3000;
			string expected = "MMM";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_3900()
		{
			int input = 3900;
			string expected = "MMMCM";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Test_3999()
		{
			int input = 3999;
			string expected = "MMMCMXCIX";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Error_4000()
		{
			int input = 4000;
			string expected = ":(";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Error_454545()
		{
			int input = 454545;
			string expected = ":(";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}
		[Test]
		public void Error_0()
		{
			int input = 0;
			string expected = ":(";

			Assert.AreEqual(expected, Roman.ToRoman(input));
		}

	}
}