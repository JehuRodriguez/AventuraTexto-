using System;


namespace AventuraTexto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LA MAZMORRA PERDIDA");
            Console.WriteLine("Bienvenido Aventurero");

            Guerrero guerrero = new Guerrero("Guerrero ", 100);
            Mago mago = new Mago("Mago ", 80);

            guerrero.Atacar();
            mago.Atacar();



            Console.ReadLine();
        }
    }
}
