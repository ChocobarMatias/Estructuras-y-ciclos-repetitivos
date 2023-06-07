using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("| Calculo de voto y su cantidad junto al promedio ganador mayor 45% |");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine();
            int candidatoC = 0;
            int candidatoQ = 0;
            int votoBlanco = 0;
            int totalVotos = 0;
            double porcentajeCandidatoC = 0;
            ConsoleKeyInfo respuesta;
            char opcion;

            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Pulse Q para votar al Candidato Q");
                Console.WriteLine("Pulse C para votar al Candidato C");
                Console.WriteLine("Pulse B para votar en blanco");
                Console.WriteLine("Pulse N para finalizar votacion");
                respuesta = Console.ReadKey();//pasamos la seleccion colocando el boton correspondiente a la seleccion
                opcion = char.ToUpper(respuesta.KeyChar);//convertimos string a char

                Console.WriteLine();
                Console.WriteLine();
                
                switch (opcion)//seleccion de los candidatos y sumamos los votos con los contadores
                {
                    case 'Q':
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine(" Votaste al candidato Q");
                            candidatoQ++;
                            Console.WriteLine();
                            Console.WriteLine(" Presione una tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 'C':
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine(" Votaste al candidato C");
                            candidatoC++;
                            Console.WriteLine();
                            Console.WriteLine(" Presione una tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 'B':
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine(" Votaste en Blanco");
                            votoBlanco++;
                            Console.WriteLine();
                            Console.WriteLine(" Presione una tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    default:
                        break;
                }
                
            } while (opcion != 'N');//condicion para salir del bucle

            totalVotos = candidatoC + candidatoQ + votoBlanco;//suma total de votos
            porcentajeCandidatoC = (candidatoC * 100) / totalVotos;//calculo del promedio
            Console.WriteLine($"Finalizo la votacion con {totalVotos} votos en total y el total de votos en blancos fue de {votoBlanco}");
            //indica el resultado si exite o no un ganador
            if (candidatoC == candidatoQ && votoBlanco > 0)
            {
                Console.WriteLine();
                Console.WriteLine("No hubo ganador en estas votaciones");
            }
            else
            {
                if (porcentajeCandidatoC >= 45)
                {
                    Console.WriteLine();
                    Console.WriteLine("El candidato C ha ganado con mas o igual al 45% de los votos");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("El candidato Q ha ganado con mas o igual al 45% de los votos");
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
