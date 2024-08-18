using System;

namespace Herencia
{
    class Program1
    {
        static void Main(string[] args)
        {

            float x1 = 3.4f;
            float x2 = 78.0f;
            float y1 = 4.4f;
            float y2 = 88.0f;
            double distancia = calculardistanciahiperespacio(x1, x2, y1, y2);
            Console.WriteLine(distancia);


        }

        static double calculardistanciahiperespacio(float x1, float x2, float y1, float y2)
        {
            double distancia = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return distancia;
        }
    }
}
