using System;

namespace Znaky
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string text = "Programátor se zasekne ve sprše, protože instrukce na šampónu byly: Namydlit, omýt, opakovat.";
			string samohlasky = "aeiouyáéěíóúůý";
			string souhlasky = "bcčdďfghjklmnpqrřsštťvwxzž";
			int pocetSamohlasek = 0;
			int pocetSouhlasek = 0;
			int pocetOstatnich = 0;
			Console.WriteLine(text);
			text.ToLower();

			foreach (char znak in text) {
				if (samohlasky.Contains (Convert.ToString(znak))) {
					pocetSamohlasek++;
				} else if (souhlasky.Contains (Convert.ToString(znak))) {
					pocetSouhlasek++;
				} else {
					pocetOstatnich++;
				}
			}

			Console.WriteLine ("================ Analýza textu ================");
			Console.WriteLine ("Počet samohlásek: " + Convert.ToString(pocetSamohlasek));
			Console.WriteLine ("Počet souhlásek: " + Convert.ToString(pocetSouhlasek));
			Console.WriteLine ("Počet ostatních znaků: " + Convert.ToString(pocetOstatnich));
		}
	}
}
