using System;


namespace AventuraTexto
{
    internal class Guerrero : Personaje
    {
        public Guerrero(string nombre, int vida) : base(nombre,vida,20)
        {


        }

        public override void Atacar()
        {
            Console.WriteLine(nombre + " ataca con espada ");
        }
    }
}
