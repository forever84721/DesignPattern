using System;

namespace DesignPattern.FactoryPattern.Color
{
    class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Red::fill() method.");
        }
    }
}
