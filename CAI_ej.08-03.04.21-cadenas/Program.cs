using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_ej._08_03._04._21_cadenas
//ej 08: Solicite al usuario el ingreso de una frase y presente un mensaje indicando si alguna 
//contiene la palabra “fin”.
{
    class Program
    {
        static void Main(string[] args)
        {
			string texto;
			string palabra = "fin";
			//bool contiene = false;


			Console.WriteLine("Ingrese una frase");
			texto = Console.ReadLine();

			if ((texto.Contains(palabra)) == true)
			{
				Console.WriteLine("Bien! su frase contiene la palabra " + palabra);
			}

			Console.WriteLine("Adios!");

			Console.ReadKey();
			
		}
    }
}
