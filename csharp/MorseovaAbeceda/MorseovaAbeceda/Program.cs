using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
			mod = Console.ReadLine ().ToLower ();
			if (mod.Equals ("a")) {
				Console.Write ("Napište text, který chcete převést do Morseovy abecedy: ");
				text = Console.ReadLine ().ToLower ();
				foreach (char znak in text) {
					if (abeceda.ContainsKey (znak)) {
						zasifrovanyText.Append (abeceda [znak]);
						zasifrovanyText.Append (" ");
					}
				}
				Console.WriteLine ("Text v Morseově abecedě: " + zasifrovanyText.ToString ());
			} else if (mod.Equals ("n")) {
				Console.WriteLine ("Znaky Morseovy abecedy oddělujte merezami.");
				Console.Write ("Napište text, který chcete převést do abecedy: ");
				text = Console.ReadLine ().ToLower ();
				string[] pole = new string[text.Length];
				pole = text.Split (' ');
				foreach (string znak in pole) {
					if (abeceda.ContainsValue (znak)) {
						foreach (KeyValuePair<char, string> klicHodnota in abeceda) {
							if (klicHodnota.Value == znak) {
								zasifrovanyText.Append (klicHodnota.Key);
							}
						}
					}
				}
				Console.WriteLine ("Dešifrovaný text: " + zasifrovanyText.ToString ());
			}
		}
	}
}
