using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ..::  Cálculo de áreas by Fabian Montoya ::.. ");
            int option = 0;

            FiguraGeometrica figura;

            while (option != 3)
            {
                Console.WriteLine("");
                Console.WriteLine("Por favor indique la opción a ejecutar:");
                Console.WriteLine("1. Calcular área Rectangulo.\n2. Calcular área Circulo.\n3. Cerrar aplicación.");
                Console.WriteLine("");
                try
                {
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("• ÁREA DE UN RECTANGULO");
                            Console.WriteLine("Por favor indique la altura: ");
                            int Altura = int.Parse(Console.ReadLine());
                            Console.WriteLine("Por favor indique la base: ");
                            int Base = int.Parse(Console.ReadLine());
                            figura = new Rectangulo(Base, Altura);

                            Console.WriteLine("");
                            Console.WriteLine("El área del rectangulo con Base " + Base + " y Altura " + Altura + " es: " + figura.Area());
                            break;
                        case 2:
                            Console.WriteLine("• ÁREA DE UN CIRCULO");
                            Console.WriteLine("Por favor indique el radio: ");
                            int Radio = int.Parse(Console.ReadLine());
                            figura = new Circulo(Radio);

                            Console.WriteLine("");
                            Console.WriteLine("El área del circulo con Radio " + Radio + " es: " + figura.Area());
                            break;
                        case 3:
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Adios, la aplicación se cerrará.");
                            break;
                        default:
                            option = 0;
                            Console.WriteLine("Opción invalida, por favor indique una opción valida.");
                            break;
                    }
                }
                catch
                {
                    option = 0;
                    Console.WriteLine("Opción invalida, el sistema solo admite la captura de números.");
                }
            }

        }
    }
}
