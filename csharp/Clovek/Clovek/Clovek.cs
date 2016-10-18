using System;

namespace Clovek
{
	public class Clovek
	{

		public string jmeno;
		public string prijmeni;
		public int vek;
		public string pozdrav;

		public Clovek() {

		}

		public Clovek (string jmeno, string prijmeni, int vek, string pozdrav)
		{
			this.jmeno = jmeno;
			this.prijmeni = prijmeni;
			this.vek = vek;
			this.pozdrav = pozdrav;
		}
	}
}

