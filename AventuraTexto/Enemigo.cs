using System;


namespace AventuraTexto
{
    internal class Enemigo : Personaje
    {


        public Enemigo(string nombre, int vida) : base(nombre, vida,15)
        {

        }


        public override void Atacar()
        {
            Console.WriteLine(nombre + "te ataca");
        }

    }
}
