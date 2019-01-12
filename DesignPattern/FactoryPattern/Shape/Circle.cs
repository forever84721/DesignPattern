using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern.Shape
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle::Draw() method.");
        }
    }
}
