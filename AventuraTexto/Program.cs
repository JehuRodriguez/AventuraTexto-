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

            Console.WriteLine();
            Console.WriteLine("Has entrado en la mazmorra.");
            Console.WriteLine("Frente a ti aparecen dos caminos.");
            Console.WriteLine();
            Console.WriteLine("1. Camino de la izquierda");
            Console.WriteLine("2. Camino de la derecha");

            Console.Write("¿Qué camino eliges? ");

            string camino = Console.ReadLine();

            if (camino == "1")
            {
                Console.WriteLine();
                Console.WriteLine("Avanzas por el camino de la izquierda.");
                Console.WriteLine("Escuchas un ruido extraño...");
            }

            else if (camino == "2")
            {
                Console.WriteLine();
                Console.WriteLine("Avanzas por el camino de la derecha.");
                Console.WriteLine("Encuentras una vieja antorcha.");
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("Te has perdido en la mazmorra.");
            }

            Console.ReadLine();
        }
    }
}


