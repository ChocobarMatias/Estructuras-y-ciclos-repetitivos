using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("Nombre de Usuario y Contraseña");
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine();
            string Usuario = "";// Variable que contendra el nombre de usuario como string
            string Contraseña = "";// Variable que contendra la contraseña
            int intentos = 0;// intentos fallidos
            int intentocontraseña = 0;// intentos fallidos en contraseña
            bool inicio = true;//Ingreso y permanencia en el While

            intentos = 0;
            //Primera solicitud al Usuario de ingresar datos
            Console.Write("  Ingresar Nombre de Usuario : ");
            Usuario = Console.ReadLine();
            inicio = true;
            //Condicion de inicio del while para ingresar con intentos y inincio con true
            while (intentos < 3 && inicio == true)
            {
                if (Usuario == "Lab1")//1° condicion if para nombre de usuario correcto
                {
                    if (intentocontraseña == 0)// condicion para diferenciar los intentos errados de contraseña
                    {                          // si es 0 le ingresa al usuario la contraseñas
                    Console.Clear();
                    Console.WriteLine();
                    Console.Write("  Ingresar Contraseña : ");
                    Contraseña = Console.ReadLine();
                    }
                    
                    if (Contraseña == "lab2023")//si coincide la contraseña ingresada con el string
                    {                           //ingresa y muestra mensaje termiando y sale del while
                        Console.Clear();        //Terminando proceso
                        Console.WriteLine();
                        Console.WriteLine("  Bienvenido Profesor");
                        inicio = false; // false para salir del while
                    }
                    else
                    {// ingresa en este else al detectar que se coloco mal contraseña
                        intentos++;//cuenta los intentos fallidos
                        intentocontraseña++;//comienzo a contar los errores en contraseña

                        if (intentocontraseña > 0 && intentos < 3)//es para solcitar contraseña cada vez
                        {                                         //que se la coloca mal 
                            Console.Clear();                 //limpio pantalla          
                            Console.WriteLine();
                            Console.WriteLine("  Datos incorrectos intente de nuevo");
                            Console.WriteLine("  ----------------------------------");
                            Console.WriteLine();
                            Console.Write("  Ingresar Contraseña : ");
                            Contraseña = Console.ReadLine();
                            
                        }
                        else//si detecta que los intentos son >= 3 sale del while
                        {
                            inicio = false;
                        }
                        
                    }

                }
                   else//esto es para los intentos errados del nombre Usuario
                    {
                    intentos ++;//cuanta los intentos fallidos

                    if (intentos < 3)//para los menos a 3 solicita ingresar nuevamente usuario
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("  Datos incorrectos intente de nuevo");
                        Console.WriteLine("  ----------------------------------");
                        Console.WriteLine();
                        Console.Write("  Ingresar Nombre de Usuario : ");
                        Usuario = Console.ReadLine();
                    }
                    else//Sale del while cuando coloca 3 veces mal el usuario
                    {
                       inicio = false;
                    }
                   
                    }
                            }
            
            if (intentos == 3)//Para 3 intentos fallidos muestra este mensaje
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("  Demasiados intentos fallidos");
            }
                        
            Console.WriteLine();
            Console.WriteLine(" *****************");
            Console.WriteLine(" |Fin del Proceso| ");
            Console.WriteLine(" *****************");
            Console.ReadKey();
        }
    }
}
