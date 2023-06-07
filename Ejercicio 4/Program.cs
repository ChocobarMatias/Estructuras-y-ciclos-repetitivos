using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" |Numeros Multiplos de 6 entre -200 y 300|");
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();

            int num1 = -200;
            int num2 = 300;
            int num = 0;//esta variable uso para acumular los numeros entre -200 a 300
            num = num1;

            while (num2 > num)
            {
                num++;
                if (num % 6 == 0)//Verificacion de Multiplos de 6
                {
                    Console.WriteLine($"  . {num}");
                }
            }
            Console.WriteLine();
            Console.WriteLine(" *******************");
            Console.WriteLine(" | Fin del Proceso |");
            Console.WriteLine(" *******************");
            Console.ReadKey();
        }
    }
}
