using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("|Suma parcial de una serie de numeros enteros positivos y su Promedio|");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int serie = 0;//Serie de numeros ingresado por el Usuario
            int suma = 0;//suma de los numeros ingresados por el Usuario
            int promedio = 0;//promedio de los numeros ingresados
            int contador = 0;//contador para contar la cantidad de veces que fue ingresada de numeros
            bool Respuesta = true;//Booleano que utilizo para continuar o terminar el ingreso de numeros
            string seguir = "";//String que utilizo para ingresar a los If
            Console.WriteLine();
            Console.WriteLine("Ingrese el inicio de la serie de numeros");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - --");
            serie = Int32.Parse(Console.ReadLine());
            suma = suma + serie;
            contador++;
            while (Respuesta == true)//Ingreso al while
            {
                Console.WriteLine();//mensaje para ver si el usuario quiere continuar o no
                Console.WriteLine(" ¿ Desea ingresar otro numero ? (S = Si / N = No) ");
                Console.WriteLine("- - - - - - - - - - - - - - - -");
                seguir = Console.ReadLine();
                if (seguir == "S" || seguir == "s")//condicion para que continue
                {
                    Respuesta = true;
                    Console.WriteLine();//solicitud de ingreso del nuevo numero
                    Console.WriteLine(" Ingrese un numero ");
                    Console.WriteLine("-------------------");
                    serie = Int32.Parse(Console.ReadLine());
                    suma = suma + serie;//acumulador de la suma parcial de la serie
                    contador++;              
                }
                else
                {//condicion para que deje de ingresar numeros
                    if (seguir == "N" || seguir == "n")
                    {
                        Console.Clear();
                        Respuesta = false;
                        promedio = suma / contador;//primedio de la serie de numeros
                        Console.WriteLine();
                        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                        Console.WriteLine("|Suma parcial de una serie de numeros enteros positivos y su Promedio|");
                        Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine(" ______________________________");
                        Console.WriteLine($"| Suma Parcial de la serie = {suma}|");
                        Console.WriteLine("  -----------------------------");
                        Console.WriteLine();
                        Console.WriteLine("  _________________________");
                        Console.WriteLine($"| Promedio de la serie = {promedio}|");
                        Console.WriteLine("  -------------------------");
                    }
                } 
            }
            Console.WriteLine();
            Console.WriteLine(" *****************");
            Console.WriteLine(" |Fin del Proceso| ");
            Console.WriteLine(" *****************");
            Console.ReadKey();
        }
    }
}
