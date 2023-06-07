﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("| Suma de los primero 100 numeros enteros iniciando desde el 1 |");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int numeros = 1;
            int suma = 0;
            //Inicie la variable numero en 1 para que se el primer numero que muestre al entrar al Bucle While
            while (numeros <= 100)
            { //No olvidar las llaves { para que entre al Bucle
                suma = suma + numeros; //suma es una acumulador donde acumulo los numeros
                
                // Utilizo el la variable numero como un contador dentro del Bucle While para que muestre
                // los numeros que va registrando antes de llegar a la condicion para llegar al 100
                numeros++; //contador ampliando en 1 cada vez
            }
            Console.WriteLine($"    Suma de los 100 primeros numeros es = {suma}");
            Console.WriteLine();
            Console.WriteLine(" *****************");
            Console.WriteLine(" |Fin del Proceso| ");
            Console.WriteLine(" *****************");
            Console.ReadKey();
        
    }
    }
}
