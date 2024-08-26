using System;

namespace Inundaciones
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Programa para evaluar inundaciones en Antioquia");
            Console.WriteLine("hay 3 tipos de inundaciones (1) Fluviales, (2) Costeras, (3) urbanas");

            int totalinudaciones = 0;
            int tipoinundacion;
            int hogaresafectados = 0;

            // cantidadhogaresafectadosportipo es el total carga y la cantidad tipo de inundaciones es el total de lanzamientos

            int[] cantidadtipoinundaciones = new int[3 + 1];

            float[] cantidadhogaresafectadosportipo = new float[3 + 1];


            for (int i = 0; i < 3; i++)
            {
                cantidadhogaresafectadosportipo[i] = 0;
                cantidadtipoinundaciones[i] = 0;
            }
            while (totalinudaciones < 12)
            {
                try
                {
                    Console.WriteLine($"ingresa el tipo de inundacion para el caso numero {totalinudaciones + 1}, (1) Fluviales, (2) Costeras, (3) urbanas ", totalinudaciones + 1);
                    tipoinundacion = int.Parse(Console.ReadLine()!);

                    if (tipoinundacion == 1 || tipoinundacion == 2 || tipoinundacion == 3)
                    {
                        try
                        {
                            Console.WriteLine("Ingresa la cantidad de hogares afectados");
                            hogaresafectados = int.Parse(Console.ReadLine()!);

                            if (hogaresafectados >= 0 && hogaresafectados <= 100)
                            {
                                switch (tipoinundacion)
                                {
                                    case 1:
                                        cantidadtipoinundaciones[1]++;
                                        cantidadhogaresafectadosportipo[1] += hogaresafectados;
                                        break;

                                    case 2:
                                        cantidadtipoinundaciones[2]++;
                                        cantidadhogaresafectadosportipo[2] += hogaresafectados;
                                        break;

                                    case 3:
                                        cantidadtipoinundaciones[3]++;
                                        cantidadhogaresafectadosportipo[3] += hogaresafectados;
                                        break;



                                }
                                totalinudaciones++;
                            }
                            else
                            {
                                Console.WriteLine("ingresaste un cantidad de hogares fuera del rango 0 a 100, intenta nuevamente ");
                            }
                        }
                        catch (FormatException error)
                        {
                            Console.WriteLine("ingresaste un dato no numerico, intenta nuevamente");
                            Console.WriteLine(error.Message);
                        }


                    }

                    else
                    {
                        Console.WriteLine("ingresaste un tipo de inundacion invalida, intentalo de nuevo");
                    }

                }

                catch (FormatException error)
                {
                    Console.WriteLine("ingresaste un dato no numerico, intenta nuevamente");
                    Console.WriteLine(error.Message);
                }

            }

            // calcularemos el promedio
            float[] promedios = CalculaPromedioAfectacion(cantidadtipoinundaciones, cantidadhogaresafectadosportipo);

            //visualizamos los resultados aqui
            Console.WriteLine("\n\nresultados obtenidos para inundaciones: \n");

            Console.Write("\nTipo de Inundacion: \tFluvial \tCostera \tUrbana");
            Console.Write("\ncantidad:                        \t");
            for (int i = 0; i < 3; i++)
                Console.Write(cantidadtipoinundaciones[i + 1] + "\t");

            Console.Write("\nhogares afectados:                \t");
            for (int i = 0; i < 3; i++)
                Console.Write(cantidadhogaresafectadosportipo[i + 1] + "\t");


            Console.Write("\npromedio:                          \t");
            for (int i = 0; i < 3; i++)
                Console.Write(promedios[i + 1] + "\t");

            Console.WriteLine();















        }

        static float[] CalculaPromedioAfectacion(int[] arregloInundaciones, float[] arregloCasas)
        {
            float[] promedios = new float[3 + 1];

            for (int i = 0; i < promedios.Length; i++)
            {
                if (arregloInundaciones[i] == 0)
                    promedios[i] = 0;
                else
                    promedios[i] = arregloCasas[i] / arregloInundaciones[i];
            }

            return promedios;
        }
    }
}
