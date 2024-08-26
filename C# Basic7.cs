

namespace FEDRA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa de proteccion ambiental de FEDRA");

            //variables
            float cantidadhogares, roedores = 0, hongos = 0, insectos = 0, nofumigados = 0, hogaresfumigados = 0;
            bool datocorrecto;

            datocorrecto = false;



            while (datocorrecto == false)
            {
                try
                {
                    Console.Write("\ndigite la cantida de casas que se fumigaron con enfasis en roedores  ");
                    roedores = float.Parse(Console.ReadLine()!);

                    if (roedores >= 0)
                        datocorrecto = true;
                    else
                        Console.WriteLine("el numero de casas debe ser mayor a cero");
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                    Console.WriteLine($"Error: {error.Message}\n");
                }

                hogaresfumigados = hogaresfumigados + roedores;
            }




            datocorrecto = false;

            while (datocorrecto == false)
            {
                try
                {
                    Console.Write("\ndigite la cantida de casas que se fumigaron con enfasis en hongos  ");
                    hongos = float.Parse(Console.ReadLine()!);

                    if (hongos >= 0)
                        datocorrecto = true;
                    else
                        Console.WriteLine("el numero de casas debe ser mayor a cero");
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                    Console.WriteLine($"Error: {error.Message}\n");
                }

                hogaresfumigados = hogaresfumigados + hongos;
            }


            datocorrecto = false;
            while (datocorrecto == false) 
            {
                try
                {
                    Console.Write("\ndigite la cantida de casas que se fumigaron con enfasis en insectos  ");
                    insectos = float.Parse(Console.ReadLine()!);

                    if (insectos >= 0)
                        datocorrecto = true;
                    else
                        Console.WriteLine("el numero de casas debe ser mayor a cero");
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                    Console.WriteLine($"Error: {error.Message}\n");
                }

                hogaresfumigados = hogaresfumigados + insectos;
            }


            datocorrecto = false;
            while (datocorrecto == false) 
            {
                try
                {
                    Console.Write("\ndigite la cantida de casas que se no fueron fumigadas  ");
                    nofumigados = float.Parse(Console.ReadLine()!);

                    if (nofumigados >= 0)
                        datocorrecto = true;
                    else
                        Console.WriteLine("el numero de casas debe ser mayor a cero");
                }
                catch (FormatException error)
                {
                    Console.WriteLine("Ingresaste un dato no numérico. Intenta nuevamente!");
                    Console.WriteLine($"Error: {error.Message}\n");
                }

                
            }



            cantidadhogares = (nofumigados + hogaresfumigados);
            float porcroedores = (roedores / cantidadhogares) * 100;
            float porchongos = (hongos / cantidadhogares) * 100;
            float porcinsectos = (insectos / cantidadhogares) * 100;
            float porcno = (nofumigados / cantidadhogares) * 100;


            Console.WriteLine("\nCalculando...");


            Console.WriteLine($"\nCantidad de casas de la residencia: {cantidadhogares}");

            Console.WriteLine($"Cantidad de casas fumigadas: {hogaresfumigados }");

            Console.WriteLine($"\nCantidad de casas no fumigadas: {nofumigados}");
            Console.WriteLine($"porcentaje de casas no fumigadas: {porcno.ToString("00.00")}%");

            Console.WriteLine($"\ntotal de casas fumigadas con enfasis en roedores: {roedores}");
            Console.WriteLine($"porcentaje de casas fumigadas con enfasis en roedores: {porcroedores.ToString("00.00")}%");
            
            Console.WriteLine($"\ntotal de casas fumigadas con enfasis en hongos: {hongos}");
            Console.WriteLine($"porcentaje de casas fumigadas con enfasis en hongos: {porchongos.ToString("00.00")}%");
            
            Console.WriteLine($"\ntotal de casas fumigadas con enfasis en insectos: {insectos}");
            Console.WriteLine($"porcentaje de casas fumigadas con enfasis en insectos: {porcinsectos.ToString("00.00")}%");

            if (roedores > hongos && roedores > insectos)
                Console.WriteLine("\nla cantidad de casas fumigadas con enfasis en roderoes fue mayor a la cantidad de casas fumigadas para otras plagas");


            if (hongos > roedores && hongos > insectos)
                Console.WriteLine("\nla cantidad de casas fumigadas con enfasis en hongos fue mayor a la cantidad de casas fumigadas para otras plagas");


            if (insectos > hongos && insectos > roedores)
                Console.WriteLine("\nla cantidad de casas fumigadas con enfasis en insectos fue mayor a la cantidad de casas fumigadas para otras plagas");


            if (hogaresfumigados == cantidadhogares) 
            Console.WriteLine("\nFumigacion Exitosa");
            else
            Console.WriteLine("\nFumigacion Incompleta");










        }
    }
}
