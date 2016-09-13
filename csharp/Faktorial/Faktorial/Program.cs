using System;

namespace Faktorial
{
	class MainClass
	{
		/**
		 * Vypočítá faktoriál
		 * @param cislo Číslo, ze kterého chceme vypočítat faktoriál
		 * @return Faktoriál
		 */
		public static int Faktorial(int cislo) {
			if (cislo <= 0) {
				return(1);
			} else {
				return (cislo * Faktorial(cislo - 1));
			}
		}

		public static void Main (string[] args)
		{
			Console.Write("Zadejte číslo, ze kterého chcete vypočítat Faktoriál: ");
			int cislo = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(Convert.ToString(Faktorial(cislo)));
		}
	}
}
