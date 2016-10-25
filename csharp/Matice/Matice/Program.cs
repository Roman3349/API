using System;

namespace Matice
{
	class MainClass
	{
		
		public static void Main (string[] args)
		{
			// Velikost matice
			int velikost = 4;
			// Vytvoření matice
			int[,] matice = new int[velikost, velikost];
			NaplnMatici(matice);
			VypisMatici(matice);
			Console.WriteLine(Determinant(matice));
		}

		/**
		 * Naplní matici náhodnými čísly od -128 až 127
		 * @param matice Matice, kterou chci naplnit náhodnými čísly
		 */
		public static void NaplnMatici(int[,] matice) {
			Random rand = new Random();
			for (int i = 0; i < matice.GetLength(0); i++) {
				for (int j = 0; j < matice.GetLength(1); j++) {
					matice [i, j] = rand.Next(-128,128);
				}
			}
		}

		/**
		 * Vypíše obsah matice
		 * @param matice Matice, kteerou chceme vypsat
		 */
		public static void VypisMatici(int[,] matice) {
			for (int i = 0; i < matice.GetLength(0); i++) {
				for (int j = 0; j < matice.GetLength(1); j++) {
					Console.Write(matice [i, j] + "\t");
				}
				Console.WriteLine ();
			}
		}

		/**
		 * Vypočítá determinant matice
		 * @param matice Matice, ze které chci vypočítat determinant
		 * @return Determinant dané matice
		 */
		public static int Determinant(int[,] matice) {
			int det = 0;
			switch (matice.GetLength(0)) {
			case 1:
				det = matice [0, 0];
				break;
			case 2:
				det = ((matice [0, 0] * matice [1, 1]) - (matice [1, 0] * matice [0, 1]));
				break;
			case 3:
				det = (
				    (matice [0, 0] * matice [1, 1] * matice [2, 2]) +
				    (matice [0, 1] * matice [1, 2] * matice [2, 0]) +
				    (matice [0, 2] * matice [1, 0] * matice [2, 1]) -
				    (matice [0, 2] * matice [1, 1] * matice [2, 0]) -
				    (matice [0, 1] * matice [1, 0] * matice [2, 2]) -
				    (matice [0, 0] * matice [1, 2] * matice [2, 1])
				);
				break;
			default:
				throw new NotImplementedException();
			}
			return det;
		}
	}
}
