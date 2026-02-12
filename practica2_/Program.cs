using System;
using System.Collections.Generic;

namespace PracticaUnidad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadPersonas = 0;

            while (cantidadPersonas < 1)
            {
                Console.Write("Ingresa la cantidad de personas (mínimo 1): ");
                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out cantidadPersonas) || cantidadPersonas < 1)
                {
                    Console.WriteLine("Error: Ingresa un número válido mayor o igual a 1.\n");
                    cantidadPersonas = 0;
                }
            }

            List<string> nombres = new List<string>();
            List<int> edades = new List<int>();

            for (int i = 0; i < cantidadPersonas; i++)
            {
                Console.WriteLine("\nPersona #" + (i + 1));

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                nombres.Add(nombre);

                int edad = -1;

                while (edad < 0)
                {
                    Console.Write("Edad: ");
                    string entradaEdad = Console.ReadLine();

                    if (!int.TryParse(entradaEdad, out edad) || edad < 0)
                    {
                        Console.WriteLine("Error: Ingresa una edad válida.");
                        edad = -1;
                    }
                }

                edades.Add(edad);
            }

            Console.WriteLine("\n==========================");

            if (cantidadPersonas == 1)
            {
                Console.WriteLine("Nombre: " + nombres[0]);

                if (edades[0] >= 18)
                {
                    Console.WriteLine("Es mayor de edad.");
                }
                else
                {
                    Console.WriteLine("Es menor de edad.");
                }
            }
            else
            {
                Console.WriteLine("\nLista General:");
                for (int i = 0; i < nombres.Count; i++)
                {
                    Console.WriteLine(nombres[i] + " - " + edades[i] + " años");
                }

                Console.WriteLine("\nMayores de edad:");
                bool hayMayores = false;

                for (int i = 0; i < nombres.Count; i++)
                {
                    if (edades[i] >= 18)
                    {
                        Console.WriteLine(nombres[i] + " - " + edades[i] + " años");
                        hayMayores = true;
                    }
                }

                Console.WriteLine("\nMenores de edad:");
                bool hayMenores = false;

                for (int i = 0; i < nombres.Count; i++)
                {
                    if (edades[i] < 18)
                    {
                        Console.WriteLine(nombres[i] + " - " + edades[i] + " años");
                        hayMenores = true;
                    }
                }

                if (!hayMayores)
                {
                    Console.WriteLine("No hay mayores de edad.");
                }

                if (!hayMenores)
                {
                    Console.WriteLine("No hay menores de edad.");
                }
            }

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
