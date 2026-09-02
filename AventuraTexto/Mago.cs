using System;


namespace AventuraTexto
{
    internal class Mago : Personaje
    {
        public Mago(string nombre, int vida) : base(nombre, vida,20)
        {

        }

        public override void Atacar()
        {
            Console.WriteLine(nombre + " lanza una bola de fuego.");
        }



    }
}
