using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Numeros enteros positivos entre A y B");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

            int A = 0;
            int B = 0;
            int numero = 0;

            A = 10;
            B = 20;
            //Rpimera Interaccion con el usuario
            Console.WriteLine();
            Console.Write(" Ingresar un numero entero : ");
            numero = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            //Condicion de ingreso al while para valores fuera de A y B 
            //Para los valores dentro de A y B sale del While
            while (numero < A || numero > B)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(" Numero ingresado no valido");
                Console.WriteLine("-----------------------------");
                Console.WriteLine();
                Console.Write(" Ingresar un numero entero : ");//Mensaje que se repite cuando ingresa mal numero
                numero = Int32.Parse(Console.ReadLine());
                Console.WriteLine();


            }
            //Mensaje cuadno ingresa valores dentro de A y B
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" Numero valido ingresado "+numero);


            Console.WriteLine();
            Console.WriteLine(" *****************");
            Console.WriteLine(" |Fin del Proceso| ");
            Console.WriteLine(" *****************");
            Console.ReadKey();
        }
    }
}
