using System;

namespace URI_1013
{
	class Program
	{
		static void Main(string[] args)
		{
			int a, b, c, maiorAB, maiorABC;

			string[] s = Console.ReadLine().Split(' ');

			a = int.Parse(s[0]);
			b = int.Parse(s[1]);
			c = int.Parse(s[2]);

			maiorAB = ((a + b) + Math.Abs(a - b)) / 2;
			maiorABC = ((maiorAB + c) + Math.Abs(maiorAB - c)) / 2;

			Console.WriteLine(maiorABC + " eh o maior"); // O resultado pedia essa linguagem informal.
		}
	}
}
