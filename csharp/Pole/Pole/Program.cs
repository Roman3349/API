using System;
using System.Linq;

namespace Pole
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] pole = new int[10];
			Random rand = new Random();
			for (int i = 0; i < pole.Length; i++) {
				pole[i] = rand.Next(1, 129);
			}
			for (int i = 0; i < pole.Length; i++) {
				Console.WriteLine(pole[i]);
			}
			Console.WriteLine("Největší číslo je: " + pole.Max());
			Console.WriteLine("Nejmenší číslo je: " + pole.Min());
			Console.WriteLine("Aritmetický průměr je: " + vypoctiAritmetickyPrumer(pole));
			Console.WriteLine("Geometrický průměr je: " + vypoctiGeometrickyPrumer(pole));
			Console.ReadLine();
		}

		/**
		 * Tato funkce vypočítá aritmetický půměr z pole
		 * @param pole Pole, ze kterého chcemem vypočítat aritmetický průměr
		 * @return Aritmetický průměr z pole
		 */
		public static double vypoctiAritmetickyPrumer(int[] pole) {
			int sum = 0;
			double avg = 0.0;
			if (pole.Length > 0) {
				for (int i = 0; i < pole.Length; i++) {
					sum += pole[i];
				}
				avg = sum / pole.Length;
			}
			return(avg);
		}
			
		/**
		 * Tato funkce vypočítá geometrický půměr z pole
		 * @param pole Pole, ze kterého chcemem vypočítat geometrický průměr
		 * @return Geometrický průměr z pole
		 */
		public static double vypoctiGeometrickyPrumer(int[] pole) {
			Int64 sum = 1;
			double avg = 0.0;
			if (pole.Length > 0) {
				for (int i = 0; i < pole.Length; i++) {
					sum *= pole[i];
				}
				avg = Math.Pow(sum, (1.0 / Convert.ToDouble(pole.Length)));
			}
			return(avg);
		}
	}
}
