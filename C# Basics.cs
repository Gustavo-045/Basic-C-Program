using System;

namespace Herencia
{
    class Program1
    {
        static void Main(string[] args)
        {
            Tropa[] ArrayTropas = new Tropa[10];

            Tropa Tropa1 = new Tropa("Calvin", 1, "ingeniero");
            Tropa Tropa2 = new Tropa("Mariela", 1, "soldado");
            Tropa Tropa3 = new Tropa("Julian", 1, "basurero");
            Tropa Tropa4 = new Tropa("Gustavo", 1, "artillero");
            Tropa Tropa5 = new Tropa("Martha", 1, "comandante");
            Tropa Tropa6 = new Tropa("Cañaso", 1, "ingeniero");
            Tropa Tropa7 = new Tropa("Stegaf", 1, "soldado");
            Tropa Tropa8 = new Tropa("Mateo", 1, "basurero");
            Tropa Tropa9 = new Tropa("Miguel", 1, "artillero");
            Tropa Tropa10 = new Tropa("LDY", 1, "comandante");

            ArrayTropas[0] = Tropa1;
            ArrayTropas[1] = Tropa2;
            ArrayTropas[2] = Tropa3;
            ArrayTropas[3] = Tropa4;
            ArrayTropas[4] = Tropa5;
            ArrayTropas[5] = Tropa6;
            ArrayTropas[6] = Tropa7;
            ArrayTropas[7] = Tropa8;
            ArrayTropas[8] = Tropa9;
            ArrayTropas[9] = Tropa10;

            Recurso[] ArrayRecursos = new Recurso[3];

            Recurso recurso1 = new Recurso("combustible", 1, "hangar");
            Recurso recurso2 = new Recurso("municion", 1, "artilleria");
            Recurso recurso3 = new Recurso("comida", 1, "comedor");

            ArrayRecursos[0] = recurso1;
            ArrayRecursos[1] = recurso2;
            ArrayRecursos[2] = recurso3;

            bool siempre = true;

            while (siempre)
            {


                Console.WriteLine("Bienvenido a el progrma para el mantenimiento de la death star");
                Console.WriteLine("DESEAS CONTINUAR?. Si deseas continuar introduce SI, si deseas salir introduce NO");
                string Resultado = Console.ReadLine();

                while (Resultado == "SI")
                {


                    Console.WriteLine("Introduce 1 para ver la info de las tropas y los recursos, Introduce 2 para entrenar tropas, introduce 3 para usar recursos, introduce 4 para reabastecer recursos, introduce 5 para iniciar operacion militar , Introduce NO para volver al menu inicial");
                    string Resultado1 = Console.ReadLine();

                    if (Resultado1 == "1")
                    {
                        GenerarRporte();
                    }

                    else if (Resultado1 == "2")
                    {

                        for (int i = 0; i < ArrayTropas.Length; i++)
                        {
                            ArrayTropas[i].AccessEntrenar();
                        }
                    }

                    else if (Resultado1 == "3")
                    {
                        for (int i = 0; i < ArrayRecursos.Length; i++)
                        {
                            ArrayRecursos[i].AccessUsarRecurso();
                        }
                    }

                    else if (Resultado1 == "4")
                    {
                        for (int i = 0; i < ArrayRecursos.Length; i++)
                        {
                            ArrayRecursos[i].AccesReabastecerRecurso();
                        }
                    }
                    
                        else if (Resultado1 == "5")
                    {
                        
                            IniciarOperacion();
                        
                    }

                    else  if (Resultado1 == "NO")
                    {
                        Resultado = "NO";
                    }


                    void GenerarRporte()
                    {
                        for (int i = 0; i < ArrayRecursos.Length; i++)
                        {
                            ArrayRecursos[i].getInfo();
                        }
                        for (int i = 0; i < ArrayTropas.Length; i++)
                        {
                            ArrayTropas[i].getInfo();
                        }

                    }

                    

                    void IniciarOperacion()
                    {
                        Console.WriteLine("Operacion Militar Iniciada");
                        recurso1.AccessUsarRecurso();
                        recurso2.AccessUsarRecurso();
                        recurso3.AccessUsarRecurso();

                    }
                }
            }
        }
    

    }

    class Tropa
    {
        private string Nombre;
        private int Rango;
        private string Especialidad;

        public Tropa()
        {

        }

        public Tropa(string nombre, int rango, string especialidad)
        {
            Nombre = nombre;
            Rango = rango;
            Especialidad = especialidad;
        }

        private void Entrenar()
        {
            if (Rango < 5)
            {
                Rango += 1;
            }
            else
            {
                Console.WriteLine("Rango maximo alcanzado");
            }
            
        }

        public void getInfo()
        {
            Console.WriteLine("Nombre del soldado:" + Nombre + "Rango:" + Rango + "Especialidad:" + Especialidad);
        }

        public void AccessEntrenar()
        {
            Entrenar();
        }

    }

    class Recurso
    {
        private string Tipo;
        private int Cantidad;
        private string Ubicacion;


        public Recurso()
        {
        }

        public Recurso(string tipo, int cantidad, string ubicacion)
        {
            Tipo = tipo;
            Cantidad = cantidad;
            Ubicacion = ubicacion;
        }

        private void UsarRecurso()
        {
            if (Cantidad > 0)
            {
                Cantidad -= 1;
            }
            else
            {
                Console.WriteLine(" recursos menores a cero, imposible gastar");
            }
            
        }

        public void AccessUsarRecurso()
        {
            UsarRecurso();
        }

        private void ReabastecerRecurso()
        {
            Cantidad += 1;
        }

        public void AccesReabastecerRecurso()
        {
            ReabastecerRecurso();
        }
        public void getInfo()
        {
            Console.WriteLine("Nombre del Recurso:" + Tipo + "Cantidad:" + Cantidad + "Ubicacion:" + Ubicacion);
        }
    }
}
