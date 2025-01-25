using System;
//using Program;
using metodo_virtual;


namespace Perro2
{
    public class Perro : Animal
    {
        public override void HacerSonido()
        {
            Console.WriteLine("El perro ladra");
        }
    }
}