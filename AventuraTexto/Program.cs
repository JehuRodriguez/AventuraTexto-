using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AventuraTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LA MAZMORRA PERDIDA");
            Console.WriteLine("Bienvenido Aventurero");

            Personaje jugador = new Personaje("Guerrero", 100);

            Console.WriteLine("Nombre " + jugador.nombre);
            Console.WriteLine("Vida " + jugador.vida);



            Console.ReadLine();
        }
    }
}
