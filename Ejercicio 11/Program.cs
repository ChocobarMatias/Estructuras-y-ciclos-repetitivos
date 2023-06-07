using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("| Ingreso sucesivo de numeros del 0 al 9 |");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int par1 = 0;
            int par2 = 0;
            int par3 = 0;
            int par4 = 0;
            int par5 = 0;
            int impar1 = 0;
            int impar2 = 0;
            int impar3 = 0;
            int impar4 = 0;
            int impar5 = 0;
            int totalPar = 0;
            int totalImpar = 0;
            int contador = 0;
            string continuidad = "";
            do
            {
                Console.WriteLine();
                Console.Write("Ingresar un número entero (del 0 al 9): ");
                int numero = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Presione 'N' si quiere finalizar: ");
                continuidad = Console.ReadLine();
                Console.WriteLine();

                if (numero >= 0 && numero <= 9)
                {
                    contador++;
                    //en esta opcion comparamos el numero el rango de 0 a 9 
                    //y se incrementa el contador cuando ingresa separando de par a impar
                    switch (numero)
                    {
                        case 0:
                            par1++;
                            break;
                        case 1:
                            impar1++;
                            break;
                        case 2:
                            par2++;
                            break;
                        case 3:
                            impar2++;
                            break;
                        case 4:
                            par3++;
                            break;
                        case 5:
                            impar3++;
                            break;
                        case 6:
                            par4++;
                            break;
                        case 7:
                            impar4++;
                            break;
                        case 8:
                            par5++;
                            break;
                        case 9:
                            impar5++;
                            break;
                    }
                }
            } while (!(continuidad == "N" || continuidad == "n"));
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(" Cantidad de Veces que fue ingresado los numeros");
            Console.WriteLine(" _______________________________________________");
            Console.WriteLine("------------------------------");
            //Cadena de if es para colocar los numero pares e impares si se usaron y su cantidad de veces 
            if (par1 > 0)//que aparece cada uno
            {
                Console.WriteLine(); 
                Console.WriteLine($" El numero 0 se ingreso {par1} vez(es)");

            }
            if (par2 > 0)
            {
                Console.WriteLine();
                Console.WriteLine($" El numero 2 se ingreso {par2} vez(es)");
            }
            if (par3 > 0)
            {
                Console.WriteLine();
                Console.WriteLine($" El numero 4 se ingreso {par3} vez(es)");
            }
            if (par4 > 0)
            {
                Console.WriteLine();
                Console.WriteLine($" El numero 6 se ingreso {par4} vez(es)");
            }
            if (par5 > 0)
            {
                Console.WriteLine();
                Console.WriteLine($" El numero 8 se ingreso {par5} vez(es)");
            }
            if (impar1 > 0)
            {
                Console.WriteLine();
                Console.WriteLine($" El numero 1 se ingreso {impar1} vez(es)");
            }
            if (impar2 > 0)
            {
                Console.WriteLine();
                Console.WriteLine($" El numero 3 se ingreso {impar2} vez(es)");
            }
            if (impar3 > 0)
            {
                Console.WriteLine();
                Console.WriteLine($" El numero 5 se ingreso {impar3} vez(es)");
            }
            if (impar4 > 0)
            {
                Console.WriteLine();
                Console.WriteLine($" El numero 7 se ingreso {impar4} vez(es)");
            }
            if (impar5 > 0)
            {
                Console.WriteLine(); 
                Console.WriteLine($" El numero 9 se ingreso {impar5} vez(es)");
            }
            Console.WriteLine("------------------------------");
            //muestra el total de numeros pares e impares ingresados
            totalPar = par1 + par2 + par3 + par4 + par5;
            totalImpar = impar1 + impar2 + impar3 + impar4 + impar5;
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($" El total de numero Pares ingresador = {totalPar}");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine($" El total de numero Impares ingresador = {totalImpar}");
            Console.WriteLine("------------------------------------------");

            Console.WriteLine();
            Console.WriteLine(" *****************");
            Console.WriteLine(" |Fin del Proceso| ");
            Console.WriteLine(" *****************");
            Console.ReadKey();
        }
    }
}
    

