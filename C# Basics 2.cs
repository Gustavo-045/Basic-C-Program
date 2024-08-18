using System;

namespace Herencia
{
    class Program1
    {
        static void Main(string[] args)
        {

            Jedi Kenobi = new Jedi("kenobi", 10, "yoda");

            Kenobi.setNivelDeFuerza();

            Console.WriteLine("Fuerza de " + Kenobi.getName() + ":" + Kenobi.getForce());

            Sith MauL = new Sith("maul", 10, "palpatine", true);

            Console.WriteLine("Fuerza de " + MauL.getName() + ":" + MauL.getForce());

            MauL.setNivelDeFuerza();
            Console.WriteLine("Fuerza de " + MauL.getName() + ":" + MauL.getForce());


        }


    }

    class Jedi
    {
        protected string Nombre;
        protected int NiveldeFuerza;
        protected string Maestro;


        public Jedi()
        {

        }

        public Jedi(string nombre, int niveldeFuerza, string maestro)
        {
            Nombre = nombre;
            NiveldeFuerza = niveldeFuerza;
            Maestro = maestro;
        }


        protected virtual void entrenar()
        {
            NiveldeFuerza += 10;
        }

        public void setNivelDeFuerza()
        {
            entrenar();
        }

        public string getName()
        {
            return Nombre;
        }

        public int getForce()
        {
            return NiveldeFuerza;
        }
    }

    class Sith : Jedi
    {
        bool LadoOscuro;
        public Sith(string nombre, int niveldeFuerza, string maestro, bool ladoOscuro)
        {
            Nombre = nombre;
            NiveldeFuerza = niveldeFuerza;
            Maestro = maestro;
            LadoOscuro = ladoOscuro;
        }

        protected override void entrenar()
        {
            if (LadoOscuro)
            {
                NiveldeFuerza += 20;
            }
        }
    }
}
