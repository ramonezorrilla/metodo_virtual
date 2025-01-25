using System;
using static metodo_virtual.Program;


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