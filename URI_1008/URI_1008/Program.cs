using System;
using System.Globalization;

namespace URI_1008
{
	class Program
	{
		static void Main(string[] args)
		{
			int id, horas;
			double valor;

			id = int.Parse(Console.ReadLine());
			horas = int.Parse(Console.ReadLine());
			valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Console.WriteLine("NUMBER = " + id);
			Console.WriteLine("SALARY = U$ " + (valor * horas).ToString("F2", CultureInfo.InvariantCulture));
		}
	}
}
