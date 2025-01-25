using System;
using Perro2;

namespace metodo_virtual
{
    public class Program
    {
       static void Main(string[] args)
        {
            Animal miAnimal = new Animal();
            miAnimal.HacerSonido(); // El animal hace un sonido

            Perro miPerro = new Perro();
            miPerro.HacerSonido(); // El perro ladra

        }

        public class Animal
        { 
            public virtual  void HacerSonido()
            {
                Console.WriteLine("El animal hace un sonido");
            }

        }



    }

}