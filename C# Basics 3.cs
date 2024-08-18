using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program1
    {
        static void Main(string[] args)
        {

            string[] Planetas = new string[5];

            Planetas[0] = "Mustafar";
            Planetas[1] = "Tatooine";
            Planetas[2] = "Hoth";
            Planetas[3] = "Naboo";
            Planetas[4] = "Endor";

            for (int i = 0; i < Planetas.Length; i++)
            {
                Console.WriteLine(Planetas[i]);
            }


            for (int i = 0; i < Planetas.Length - 1; i++)
            {
                string temp = null;
                for (int j = i + 1; j < Planetas.Length; j++)
                {
                    temp = Planetas[i];
                    Planetas[i] = Planetas[j];
                    Planetas[j] = temp;
                }

            }


            Console.WriteLine("-------------------");

            for (int i = 0; i < Planetas.Length; i++)
            {
                Console.WriteLine(Planetas[i]);
            }



        }


    }
}
