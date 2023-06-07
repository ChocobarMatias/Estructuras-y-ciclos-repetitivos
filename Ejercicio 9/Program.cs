using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine(" | Tablas de multiplicar del un numero |");
            Console.WriteLine(" +++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int numero = 0;//numero ingresado por el usuario que indica la tabla que se mostrara
            int multiplicacion = 0; // variable que guarda operacion aritmetica del producto
            Console.Write(" Ingresar el numero que desea saber su tabla de multiplicar : ");
            numero = Int32.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine();//Mensaje que muestra la tabla de multiplicar elegida por el numero
            Console.WriteLine(" +++++++++++++++++++++++++++++++");
            Console.WriteLine($" | Tablas de multiplicar del {numero} |");
            Console.WriteLine(" +++++++++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine("  --------------");
            for (int i = 1; i <= 10; i++)//ciclo for para el calculo de la tabla del 1 al 10
            {
                if(numero > 0 )
                    {
                    multiplicacion = numero * i;
                    Console.WriteLine($"  | {numero} * {i} = {multiplicacion}");//muestra del producto
                } }

            Console.WriteLine("  --------------");
            Console.WriteLine();
            Console.WriteLine(" *****************");
            Console.WriteLine(" |Fin del Proceso| ");
            Console.WriteLine(" *****************");
            Console.ReadKey();
        }
    }
}
