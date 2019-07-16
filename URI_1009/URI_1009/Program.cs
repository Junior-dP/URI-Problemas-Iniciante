using System;

namespace URI_1009
{
	class Program
	{
		static void Main(string[] args)
		{
			string nome;
			double fixo, total;

			nome = Console.ReadLine();
			fixo = double.Parse(Console.ReadLine());
			total = double.Parse(Console.ReadLine());

			Console.WriteLine("TOTAL = R$ " + (total / 100 * 15 + fixo).ToString("F2"));
		}
	}
}
