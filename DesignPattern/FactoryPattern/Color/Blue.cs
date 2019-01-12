using System;
namespace DesignPattern.FactoryPattern.Color
{
    class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Inside Blue::fill() method.");
        }
    }
}
