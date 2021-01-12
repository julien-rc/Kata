using System;

namespace KATA_Diamond
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Diamond.Create('a'));
			Console.WriteLine(Diamond.Create('b'));
			Console.WriteLine(Diamond.Create('c'));
			Console.WriteLine(Diamond.Create('1'));
			Console.WriteLine(Diamond.Create('%'));
			Console.WriteLine(Diamond.Create('g'));
			Console.WriteLine(Diamond.Create('é'));
			Console.WriteLine(Diamond.Create('z'));
			Console.WriteLine(Diamond.Create('z'));
			Console.WriteLine(Diamond.Create('A'));
			Console.WriteLine(Diamond.Create('B'));
			Console.WriteLine(Diamond.Create('C'));
			Console.WriteLine(Diamond.Create('F'));
			Console.WriteLine(Diamond.Create('U'));
			Console.WriteLine(Diamond.Create('Z'));
			Console.WriteLine(Diamond.Create('Z'));

			Console.Read();
		}
	}
}
