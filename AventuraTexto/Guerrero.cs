using System;


namespace AventuraTexto
{
    internal class Guerrero : Personaje
    {
        public Guerrero(string nombre, int vida) : base(nombre,vida)
        {


        }

        public override void Atacar()
        {
            Console.WriteLine(nombre + "ataca con espada ");
        }
    }
}
