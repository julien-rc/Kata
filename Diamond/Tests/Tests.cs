using KATA_Diamond;
using NUnit.Framework;

namespace Tests
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void A_Test()
		{
			var input = 'A';
			var expected = "A";

			Assert.AreEqual(expected, Diamond.Create(input));
		}

		[Test]
		public void B_Test()
		{
			var input = 'B';
			var expected = " A\r\nB B\r\n A";

			Assert.AreEqual(expected, Diamond.Create(input));
		}

		[Test]
		public void C_Test()
		{
			var input = 'C';
			var expected =
				"  A\r\n" +
				" B B\r\n" +
				"C   C\r\n" +
				" B B\r\n" +
				"  A";

			Assert.AreEqual(expected, Diamond.Create(input));
		}

		[Test]
		public void E_Test()
		{
			var input = 'E';
			var expected =
				"    A\r\n" +
				"   B B\r\n" +
				"  C   C\r\n" +
				" D     D\r\n" +
				"E       E\r\n" +
				" D     D\r\n" +
				"  C   C\r\n" +
				"   B B\r\n" +
				"    A";

			Assert.AreEqual(expected, Diamond.Create(input));
		}

		[Test]
		public void Non_Letter_Error_Test()
		{
			var input = '$';
			var expected = ":(";

			Assert.AreEqual(expected, Diamond.Create(input));
		}

		[Test]
		public void Non_Basic_ASCII_Error_Test()
		{
			var input = 'é';
			var expected = ":(";

			Assert.AreEqual(expected, Diamond.Create(input));
		}

		[Test]
		public void Digit_Error_Test()
		{
			var input = '2';
			var expected = ":(";

			Assert.AreEqual(expected, Diamond.Create(input));
		}

		[Test]
		public void Blank_Error_Test()
		{
			var input = '\0';
			var expected = ":(";

			Assert.AreEqual(expected, Diamond.Create(input));
		}

		[Test]
		public void Scandinave_O_Error_Test()
		{
			var input = 'ø';
			var expected = ":(";

			Assert.AreEqual(expected, Diamond.Create(input));
		}
	}
}