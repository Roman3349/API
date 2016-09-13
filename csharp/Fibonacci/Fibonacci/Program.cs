using System;

namespace Fibonacci
{
	class MainClass
	{
		/**
		 * Vypočítá Fibonacciho číslo
		 * @param cislo Číslo, ze kterého chceme vypočítat Fibonacciho číslo
		 * @return Fibonacciho číslo
		 */
		public static int Fibonacci(int cislo) {
			if (cislo < 2) {
				return(cislo);
			} else {
				return (Fibonacci(cislo - 1) + Fibonacci(cislo - 2));
			}
		}

		public static void Main (string[] args)
		{
			Console.Write("Zadejte číslo, ze kterého chcete vypočítat Fibonacciho číslo: ");
			int cislo = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(Convert.ToString(Fibonacci(cislo)));
		}
	}
}
