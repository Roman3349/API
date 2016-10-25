using System;

namespace Vyjimky
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Dělení 2 čísel:");
			int x = 0;
			int y = 0;
			float result = 0;

			try {
				Console.Write("Zadej 1. číslo: ");
				x = Convert.ToInt32(Console.ReadLine());
				Console.Write("Zadej 2. číslo: ");
				y = Convert.ToInt32(Console.ReadLine());
			} catch (FormatException e) {
				Console.WriteLine("Neumíš napsat číslo?");
			}

			try {
				result = x / y;
			} catch (DivideByZeroException e) {
				Console.WriteLine("Dělit nulou nelze!");
			} finally {
				Console.WriteLine("Výsledek dělení je " + Convert.ToString(result));
			}
		}
	}
}
