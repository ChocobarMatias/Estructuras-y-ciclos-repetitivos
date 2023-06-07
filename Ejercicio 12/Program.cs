using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" +++++++++++++++++++++++++++++++++");
            Console.WriteLine(" |Verificar si un numero es primo| ");
            Console.WriteLine(" +++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int numero = 0;//numero ingressado por el usuario
            int contador = 0;//cuenta la cantidad de veces se realiza la operacion aritmetica
            int division = 0;//variable contiene la operacion aritmetica para ser primo
            Console.Write(" Ingresar un numero entero distinto de 0 : ");
            numero = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < numero; i++)//ciclo para verificar de 1 a numero
            {
                division = numero % i;
                 if (division == 0)//cuenta solamente cuando es distinto de cero
                {
                    contador++;
                                   }
            }
            Console.WriteLine();
            Console.Clear();
            if (contador == 2)//muestra mensaje en pantalla cuando es distinto de 2 para ser primo
            {
                Console.WriteLine();
                Console.WriteLine($" El numero {numero} Si es primo ");
                }
            else
            {
                Console.WriteLine();
                Console.WriteLine($" El numero { numero} NO es primo ");
                  }

            


            Console.WriteLine();
            Console.WriteLine(" *****************");
            Console.WriteLine(" |Fin del Proceso| ");
            Console.WriteLine(" *****************");
            Console.ReadKey();
        }
    }
}
