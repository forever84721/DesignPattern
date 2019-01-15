using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypePattern
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            ShapeType = ShapeType.Rectangle;
        }
        public override void Draw()
        {
            Console.WriteLine("Inside Rectangle::Draw() method.");
        }
    }
}
