using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" | Simulador de lanzamiento de 2 dados |");
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            Console.ReadKey();
            int suma = 0;//variable que suma los numero aleatorios que dan los dados
           
            //aqui generamos los numeros aleatorios para ambos dados
                Random generador = new Random();
                int dado1 = generador.Next(1, 7);
                int dado2 = generador.Next(1, 7);
                suma = dado1 + dado2;//suma de los numeros aleatorios

            Console.WriteLine();
            Console.WriteLine(" ---------------------------------------- ");
            Console.WriteLine(" Presione una tecla para lanzar los dados ");
            Console.WriteLine(" ---------------------------------------- ");
            Console.ReadKey();
            Console.WriteLine();
       
            if (suma >10)//Condicion para mostrar la suma cuando es mayorr a 10
            {
                  Console.Clear();
                Console.WriteLine();
                Console.WriteLine($" La suma de los dados es : {suma}");
                Console.WriteLine();
                Console.WriteLine("----------------------");
                Console.WriteLine(" Bien hecho jugador/a ");
                Console.WriteLine("----------------------");
            }

            Console.WriteLine();
            Console.WriteLine(" *****************");
            Console.WriteLine(" |Fin del Proceso| ");
            Console.WriteLine(" *****************");
            Console.ReadKey();
        }
    }
}
