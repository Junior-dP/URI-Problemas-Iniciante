using System;

namespace URI_1012
{
	class Program
	{
		static void Main(string[] args)
		{
			double pi = 3.14159;
			double a, b, c;
			double triangulo, circulo, trapezio, quadrado, retangulo;

			string[] s = Console.ReadLine().Split(' ');

			a = double.Parse(s[0]);
			b = double.Parse(s[1]);
			c = double.Parse(s[2]);

			triangulo = (a * c) / 2;
			circulo = pi * Math.Pow(c, 2);
			trapezio = (a + b) / 2 * c;
			quadrado = Math.Pow(b, 2);
			retangulo = a * b;

			Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
			Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
			Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
			Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
			Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));
		}
	}
}
