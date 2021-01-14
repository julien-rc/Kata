using KATA_FooBarQix;
using NUnit.Framework;

namespace Tests
{
	public class Tests
	{
		[Test]
		public void Test_1()
		{
			var input = 1;
			var expected = "1";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
		[Test]
		public void Test_2()
		{
			var input = 2;
			var expected = "2";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
		[Test]
		public void Test_3()
		{
			var input = 3;
			var expected = "FooFoo";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
		[Test]
		public void Test_4()
		{
			var input = 4;
			var expected = "4";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
		[Test]
		public void Test_5()
		{
			var input = 5;
			var expected = "BarBar";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
		[Test]
		public void Test_6()
		{
			var input = 6;
			var expected = "Foo";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
		[Test]
		public void Test_7()
		{
			var input = 7;
			var expected = "QixQix";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
		[Test]
		public void Test_8()
		{
			var input = 8;
			var expected = "8";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
		[Test]
		public void Test_9()
		{
			var input = 9;
			var expected = "Foo";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
		[Test]
		public void Test_10()
		{
			var input = 10;
			var expected = "Bar";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
		[Test]
		public void Test_13()
		{
			var input = 13;
			var expected = "Foo";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
		[Test]
		public void Test_15()
		{
			var input = 15;
			var expected = "FooBarBar";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
		[Test]
		public void Test_33()
		{
			var input = 33;
			var expected = "FooFooFoo";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
		[Test]
		public void Test_51()
		{
			var input = 51;
			var expected = "FooBar";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
		[Test]
		public void Test_53()
		{
			var input = 53;
			var expected = "BarFoo";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
		[Test]
		public void Test_100()
		{
			var input = 100;
			var expected = "Bar";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
		[Test]
		public void Error_0()
		{
			var input = 0;
			var expected = ":(";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
		[Test]
		public void Error_101()
		{
			var input = 101;
			var expected = ":(";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
		[Test]
		public void Error_Negative()
		{
			var input = -7;
			var expected = ":(";

			Assert.AreEqual(expected, FooBarQix.DoFooBarQix(input));
		}
	}
}