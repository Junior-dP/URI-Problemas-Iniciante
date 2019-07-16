using System;

namespace URI_1010
{
	class Program
	{
		static void Main(string[] args)
		{
			int codigo1, quantidade1, codigo2, quantidade2;
			double valor1, valor2, total;

			string[] s1 = Console.ReadLine().Split(' ');
			string[] s2 = Console.ReadLine().Split(' ');

			codigo1 = int.Parse(s1[0]);
			quantidade1 = int.Parse(s1[1]);
			valor1 = double.Parse(s1[2]);

			codigo2 = int.Parse(s2[0]);
			quantidade2 = int.Parse(s2[1]);
			valor2 = double.Parse(s2[2]);

			total = quantidade1 * valor1 + quantidade2 * valor2;

			Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));

			Console.ReadLine();
		}
	}
}
