using System;

namespace URI_1002
{
	class Program
	{
		static void Main(string[] args)
		{
			double raio, n, area;

			n = 3.14159;
			raio = double.Parse(Console.ReadLine());
			area = n * Math.Pow(raio, 2.0);
			Console.WriteLine("A=" + area.ToString("F4"));
		}
	}
}
