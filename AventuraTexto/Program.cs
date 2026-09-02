using System;


namespace AventuraTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LA MAZMORRA PERDIDA");
            Console.WriteLine("Bienvenido aventurero.");

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
            Console.WriteLine("Has elegido a " + jugador.nombre);
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
                Console.ReadKey();
                return;
            }

            Enemigo enemigo = new Enemigo("Goblin", 60);

            Console.WriteLine();
            Console.WriteLine("¡Un " + enemigo.nombre + " aparece frente a ti!");
            Console.WriteLine("Tu vida: " + jugador.vida);
            Console.WriteLine("Vida del enemigo: " + enemigo.vida);

            Console.WriteLine();

            while (jugador.vida > 0 && enemigo.vida > 0)
            {
                Console.WriteLine("¿Qué deseas hacer?");
                Console.WriteLine("1. Atacar");
                Console.WriteLine("2. Curarse");

                Console.Write("Elige una opción: ");

                string accion = Console.ReadLine();


                if (accion == "1")
                {
                    jugador.Atacar();
                    enemigo.vida = enemigo.vida - jugador.daño;

                    Console.WriteLine("El Goblin tiene " + enemigo.vida + " de vida.");
                }

                else if (accion == "2")
                {
                    jugador.vida = jugador.vida + 10;

                    Console.WriteLine("Te has curado 10 puntos.");
                    Console.WriteLine("Tu vida: " + jugador.vida);
                }

                else
                {
                    Console.WriteLine("Opción no válida.");
                    continue;
                }

                if (enemigo.vida > 0)
                {
                    enemigo.Atacar();
                    jugador.vida = jugador.vida - enemigo.daño;

                    Console.WriteLine("Tu vida: " + jugador.vida);
                }

                Console.WriteLine();
            }

            if (jugador.vida <= 0)
            {
                Console.WriteLine("El Goblin te ha derrotado.");
                Console.WriteLine();
                Console.WriteLine("GAME OVER");
            }

            else
            {
                Console.WriteLine("¡Has derrotado al Goblin!");
                Console.WriteLine();
                Console.WriteLine("Has encontrado el tesoro perdido.");
                Console.WriteLine();
                Console.WriteLine("================================");
                Console.WriteLine("        ¡HAS GANADO!");
                Console.WriteLine("================================");
            }

            Console.ReadLine();

        }
    }
}


