using System;
using System.Text;

namespace Caesarovasifra
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string puvodniText;
			StringBuilder zasifrovanyText = new StringBuilder();
			int posunuti = 0;
			int cisloZnaku = 0;
			Console.Write ("Napište text, který chcete zašifrovat: ");
			puvodniText = Console.ReadLine ();
			Console.Write ("Napište o kolik znaků chcete text posunout: ");
			posunuti = Convert.ToInt16 (Console.ReadLine());
			puvodniText = puvodniText.ToLower ();
			Console.WriteLine ("Původní text: " + puvodniText);
			foreach (char znak in puvodniText) {
				cisloZnaku = Convert.ToInt32 (znak);
				cisloZnaku += posunuti;
				if (cisloZnaku > 'z') {
					cisloZnaku -= 26;
				} else if (cisloZnaku < 'a') {
					cisloZnaku += 26;
				}
				zasifrovanyText.Append (Convert.ToChar (cisloZnaku));
			}
			Console.WriteLine ("Zašifrovaný text: " + zasifrovanyText.ToString ());
		}
	}
}
