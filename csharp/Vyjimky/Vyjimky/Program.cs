using System;

namespace Vyjimky
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Dělení 2 čísel:");
			double x = 0.0;
			double y = 0.0;
			double result = 0;

			try {
				Console.Write("Zadej 1. číslo: ");
				x = OsetriCislo(Console.ReadLine());
				Console.Write("Zadej 2. číslo: ");
				y = OsetriCislo(Console.ReadLine());
			} catch (FormatException e) {
				Console.WriteLine("Neumíš napsat číslo?");
			}

			try {
				result = Deleni(x, y);
			} catch (DivideByZeroException e) {
				Console.WriteLine("Dělit nulou nelze!");
			} finally {
				Console.WriteLine("Výsledek dělení je " + Convert.ToString(result));
			}
		}

		public static double OsetriCislo(String x) {
			return (Convert.ToDouble(x));
		}

		public static double Deleni (double x, double y) {
			return (x / y);
		}
	}
}
