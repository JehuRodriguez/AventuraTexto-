using System;


namespace AventuraTexto
{
    internal class Personaje
    {
        public string nombre;
        public int vida; 

        public Personaje(string nombre, int vida)
        {
            this.nombre = nombre;
            this.vida = vida;
        }

        public virtual void Atacar()
        {
            Console.WriteLine(nombre + "ataca.");

        }
    }
}
