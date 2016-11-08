using System;
using System.Collections;
using System.Text;

namespace Palindrom
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string text0;
			StringBuilder text1 = new StringBuilder ();
			StringBuilder text2 = new StringBuilder ();
			ArrayList zakazaneZnaky = new ArrayList() {
				';',' ',',','.','-','_','"','!','?','\'','\t','\r','\n'
			};
			Console.Write ("Zadejte text: ");
			text0 = Console.ReadLine ();
			Console.WriteLine ("Zadal jste texto text: " + text0);
			text0 = text0.ToLower ();

			foreach (char znak in text0) {
				if (!zakazaneZnaky.Contains (znak)) {
					text1.Append (znak);
				}
			}
			for (int i = (text0.Length - 1); i >= 0; i--) {
				char znak = text0[i];
				if (!zakazaneZnaky.Contains (znak)) {
					text2.Append (znak);
				}
			}

			if (text1.ToString () == text2.ToString ()) {
				Console.WriteLine ("Zadaný text je palindrom.");
			} else {
				Console.WriteLine ("Zadaný text není palindrom.");
			}
		}
	}
}
