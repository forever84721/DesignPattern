using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypePattern
{
    public class Circle : Shape
    {
        public Circle()
        {
            ShapeType = ShapeType.Circle;
        }
        public override void Draw()
        {
            Console.WriteLine("Inside Circle::Draw() method.");
        }
    }
}
