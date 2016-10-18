using System;
using System.Collections;

namespace Clovek
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ArrayList lide = new ArrayList ();
			//lide.Add (new Clovek("Petr", "Drahos", 38, "Dobrý den!"));
			//lide.Add (new Clovek("Petr", "Mikulášek", 37, "Dobrý den!"));
			Console.WriteLine ("Zadej 4 lidi: ");
			for (int i = 0; i < 4; i++) {
				Console.WriteLine ("**********************************************");
				Console.Write ("Jméno: ");
				string jmeno = Console.ReadLine ();
				Console.Write ("Příjmení: ");
				string prijmeni = Console.ReadLine ();
				Console.Write ("Věk: ");
				int vek = Convert.ToInt16(Console.ReadLine ());
				Console.Write ("Pozdrav: ");
				string pozdrav = Console.ReadLine ();
				lide.Add (new Clovek(jmeno, prijmeni, vek, pozdrav));
			}
			Console.WriteLine ("**********************************************");
			bool nalezen = false;
			Console.Write ("Jméno hledané osoby: ");
			string _jmeno = Console.ReadLine ();
			if (!nalezen) {
				foreach (Clovek clovek in lide) {
					if (clovek.jmeno == _jmeno) {
						Console.WriteLine ("**********************************************");
						Console.WriteLine ("Jméno: " + clovek.jmeno + " " + clovek.prijmeni);
						Console.WriteLine ("Věk: " + Convert.ToString (clovek.vek));
						nalezen = true;
					}
				}
				if (!nalezen) {
					Console.WriteLine ("Neznám člověka s tímto jménem.");
				}
			}
		}
	}
}
