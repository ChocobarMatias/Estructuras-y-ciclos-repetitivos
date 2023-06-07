using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" ++++++++++++++++++++++++++++++++");
            Console.WriteLine(" |Numero pares entre num1 y num2| ");
            Console.WriteLine(" ++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int num1 = 0;
            int num2 = 0;
            int num = 0;

            Console.Write(" Ingresar primer numero : ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write(" Ingresar segundo numero : ");
            num2 = Int32.Parse(Console.ReadLine());
            num = num1; //Utilizo num como el numero auxiliar que al igualar al num1 comienzo dentro del rango con su minimo
            while (num < num2)//la condicion tiene que ser realzada con num para que funcione el while
            {
                num++;//incremento a num para mantenerme dentro del rango 
                if (num % 2 == 0 && num != num2)
                {
                    Console.WriteLine();
                    Console.WriteLine($" Numero par entre ({num1} y {num2}) es : {num}");
                }
            }
            Console.WriteLine();
            Console.WriteLine(" *******************");
            Console.WriteLine(" | Fin del Proceso | ");
            Console.WriteLine(" *******************");
            Console.ReadKey();
        } } }
    

