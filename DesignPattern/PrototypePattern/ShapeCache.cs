using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypePattern
{
    public class ShapeCache
    {
        private static Dictionary<int, Shape> dictionary = new Dictionary<int, Shape>();
        public static Shape GetShape(int Id)
        {
            return dictionary[Id].Clone();
        }
        public static void LoadCache()
        {
            Circle circle = new Circle();
            circle.Id = 1;
            dictionary.Add(circle.Id, circle);
            Rectangle rectangle = new Rectangle();
            rectangle.Id = 2;
            dictionary.Add(rectangle.Id, rectangle);
            Square square = new Square();
            square.Id = 3;
            dictionary.Add(square.Id, square);
        }
    }
}
