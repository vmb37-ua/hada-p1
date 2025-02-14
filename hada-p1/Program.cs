using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            double cant;

            do
            {
                Console.Write("Introduce unidad a convertir (m / s): ");
                respuesta = Console.ReadLine();
                Console.Write("Introduce cantidad: ");
                cant = double.Parse(Console.ReadLine());

                double resultado;

                if (respuesta == "m")
                {
                    resultado = HadaP1.Minutes2Seconds(cant);
                    Console.WriteLine("Son {0} segundos.", resultado);
                }
                else if (respuesta == "s")
                {
                    resultado = HadaP1.Seconds2Minutes(cant);
                    Console.WriteLine("Son {0} minutos.", resultado);
                }
                else
                {
                    Console.WriteLine("Error, unidad no válida.");
                }

                Console.WriteLine("Deseas volver a calcular un valor? (S/N): ");
                respuesta = Console.ReadLine();
            } while (respuesta != "N");
        }
    }
}
