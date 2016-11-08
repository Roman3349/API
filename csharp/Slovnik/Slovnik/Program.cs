using System;
using System.Collections.Generic;

namespace Slovnik
{
	class MainClass
	{
		private static Dictionary<string, string> words = new Dictionary<string, string> () {
			{"hello", "ahoj"}, {"goodbye", "nashledanou"}, {"good morning", "dobré ráno"}, 
			{"boss", "šéf"}, {"", ""}, {"", ""}, {"", ""},
			{"key", "klíč"}, {"value", "hodnota"}, {"", ""}, {"", ""},
			{"computer", "počítač"}, {"keyboard", "klávesnice"}, {"", ""}, {"", ""},
			{"glasses", "brýle"}, {"", ""}, {"", ""}, {"", ""},
			{"head ache", "bolest hlavy"}, {"toothache", "bolest zubu"},
			{"", ""}, {"", ""}, {"", ""}, {"", ""},
			{"", ""}, {"", ""}, {"", ""}, {"", ""},
			{"", ""}, {"", ""}, {"", ""}, {"", ""},
			{"", ""}, {"", ""}, {"", ""}, {"", ""},
			{"", ""}, {"", ""}, {"", ""}, {"", ""},
			{"", ""}, {"", ""}, {"", ""}, {"", ""},
			{"", ""}, {"", ""}, {"", ""}, {"", ""}
			
		}

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
		}
	}
}
