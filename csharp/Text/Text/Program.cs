using System;
using System.IO;

namespace Text {
	class MainClass {
		public static void Main (string[] args) {
			FileStream stream = null;
			DateTime time = DateTime.Now;
			create (stream, time);
			read (stream, time);
		}

		public static void create (FileStream stream, DateTime time) {
			try {
				stream = new FileStream (@"../../log/" + time.ToString("yyyy-MM-dd-HH-mm-ss") + ".log" , FileMode.CreateNew);
				StreamWriter writer = new StreamWriter(stream);
				writer.WriteLine("Jmeno;Prijmeni;IQ");
				bool pridat = true;
				while (pridat) {
					Console.Write("Chcete přidat uživatele [y/N]: ");
					char znak = Console.ReadKey().KeyChar;
					Console.WriteLine();
					pridat = (znak == 'y' || znak == 'Y') ? true : false;
					if (pridat) {
						String jmeno, prijmeni = null;
						Int32 iq = 0;
						Console.Write ("Jméno: ");
						jmeno = Console.ReadLine();
						Console.Write ("Příjmení: ");
						prijmeni = Console.ReadLine();
						Console.Write ("IQ: ");
						iq = Convert.ToInt32(Console.ReadLine());
						writer.WriteLine(jmeno + ";" + prijmeni + ";" + Convert.ToString(iq));
					}
				}
				writer.Close ();
			} finally {
				stream.Close ();
			}
		}

		public static void read (FileStream stream, DateTime time) {
			try {
				stream = new FileStream (@"../../log/" + time.ToString("yyyy-MM-dd-HH-mm-ss") + ".log" , FileMode.Open);
				StreamReader reader = new StreamReader(stream);
				String line = null;
				Console.WriteLine("-------------------------------");
				while ((line = reader.ReadLine()) != null) {
					String[] array = line.Split(';');
					Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", array[0], array[1], array[2]));
					Console.WriteLine("-------------------------------");
				}
			} finally {
				stream.Close ();
			}
		}
	}
}
