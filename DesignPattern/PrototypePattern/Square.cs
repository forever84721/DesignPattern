using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypePattern
{
    public class Square : Shape
    {
        public Square()
        {
            ShapeType = ShapeType.Square;
        }
        public override void Draw()
        {
            Console.WriteLine("Inside Square::Draw() method.");
        }
    }
}
