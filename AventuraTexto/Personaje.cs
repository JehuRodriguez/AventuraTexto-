using System;


namespace AventuraTexto
{
    internal class Personaje
    {
        public string nombre;
        public int vida;
        public int daño;


        public Personaje(string nombre, int vida, int daño)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.daño = daño;
        }

        public virtual void Atacar()
        {
            Console.WriteLine(nombre + "ataca.");

        }
    }
}
