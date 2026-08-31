using System;


namespace AventuraTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LA MAZMORRA PERDIDA");
            Console.WriteLine("Bienvenido Aventurero");

            Console.WriteLine();
            Console.WriteLine("Elige tu personaje:");
            Console.WriteLine("1. Guerrero");
            Console.WriteLine("2. Mago");

            Console.Write("Escribe una opción: ");

            string opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Guerrero guerrero = new Guerrero("Guerrero", 100);

                Console.WriteLine("Has elegido al Guerrero.");
                guerrero.Atacar();
            }

            else if (opcion == "2")
            {
                Mago mago = new Mago("Mago", 80);

                Console.WriteLine("Has elegido al Mago.");
                mago.Atacar();
            }

            else
            {
                Console.WriteLine("Opción no válida.");
            }

            Console.ReadLine();
        }
    }
}
