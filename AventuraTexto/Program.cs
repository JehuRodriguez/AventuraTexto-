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

            Personaje jugador;

            if (opcion == "1")
            {
                jugador = new Guerrero("Guerrero", 100);
            }

            else if (opcion == "2")
            {
                jugador = new Mago("Mago", 80);
            }

            else
            {
                Console.WriteLine("Opción no válida.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine();
            Console.WriteLine(" Has elegido a " + jugador.nombre);
            jugador.Atacar();

            Console.ReadLine();
        }
    }
}
