using System;

namespace DesignPattern.FactoryPattern.Color
{
    class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Green::fill() method.");
        }
    }
}
