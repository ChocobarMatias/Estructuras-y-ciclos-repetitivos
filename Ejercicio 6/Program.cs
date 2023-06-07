using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" ++++++++++++++++++++++++++++");
            Console.WriteLine(" |Ciclo For numeros de 1 a N|");
            Console.WriteLine(" ++++++++++++++++++++++++++++");
            Console.WriteLine();
            int N = 0;//Numero que ingresara el Usuario mayor que cero
            Console.WriteLine("Ingresar un numero");//Mensaje que se imprime en pantalla para el Usuario
            Console.WriteLine("******************");
            Console.Write("   ");
            N = Int32.Parse(Console.ReadLine());//Lectura del valor ingresado por el usuario

            Console.Clear();//Limpieza de pantalla
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"Secuencia de numeros desde 1 a {N}");
            Console.WriteLine("---------------------------------");
            Console.WriteLine();
            for (int i = 1; i <= N && N > 0; i++)//ciclo for para N > 0 inicio del 1 hasta N 
            {
                Console.WriteLine($" . {i}");
            }
            Console.WriteLine();
            Console.WriteLine(" *****************");
            Console.WriteLine(" |Fin del Proceso| ");
            Console.WriteLine(" *****************");

            Console.ReadKey();
        }
    }
}
