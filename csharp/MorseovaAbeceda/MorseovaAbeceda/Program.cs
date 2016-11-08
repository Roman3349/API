using System;
using System.Collections.Generic;
using System.Text;

namespace MorseovaAbeceda
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Dictionary<char, string> abeceda = new Dictionary<char, string> () {
				{'a', ".-"}, {'b', "-.."}, {'c', "-.-."}, 
				{'d', "-.."}, {'e', "."}, {'f', "..-."},
				{'g', "--."}, {'h', "...."}, /* {'ch', "----"}, */ 
				{'i', ".."}, {'j', ".---"}, {'k', "-.-"}, 
				{'l', ".-.."}, {'m', "--"}, {'n', "-."}, 
				{'o', "---"}, {'p', ".--."}, {'q', "--.-"},
				{'r', ".-."}, {'s', "..."}, {'t', "-"}, 
				{'u', "..-"}, {'v', "...-"}, {'w', ".--"}, 
				{'x', "-..-"}, {'y', "-.--"}, {'z', "--.."}, 
				{'0', "-----"}, {'1', ".----"}, {'2', "..---"},
				{'3', "...--"}, {'4', "....-"}, {'5', "....."}, 
				{'6', "-...."}, {'7', "--..."}, {'8', "---.."}, 
				{'9', "----."}, {'?', "..--.."}, {',', "--..--"}, 
				{'!', "--...-"}, {'.', ".-.-.-"}, {';', "-.-.-."},
				{'/', "-..-."}, {'=', "-...-"}, {'-', "-....-"}, 
				{'(', "-.--."}, {')', "-.--.-"}, {'"', ".-..-."}, 
				{':', "---..."}, {'_', "..--.-"}, {'@', ".--.-."}
			};
			string text;
			StringBuilder zasifrovanyText = new StringBuilder ();
			string mod;
			Console.Write ("Chcete převést text do Morseovy abecedy? [A/n] ");
			mod = Console.ReadLine ();
			mod = mod.ToLower ();
			if (mod.Equals ("a")) {
				Console.Write ("Napište text, který chcete převést do Morseovy abecedy: ");
				text = Console.ReadLine ();
				text = text.ToLower ();
				foreach (char znak in text) {
					if (abeceda.ContainsKey (znak)) {
						zasifrovanyText.Append (abeceda [znak]);
						zasifrovanyText.Append (" ");
					}
				}
				Console.WriteLine ("Text v Morseově abecedě: " + zasifrovanyText.ToString ());
			} else if (mod.Equals ("n")) {
				
			}
		}
	}
}
