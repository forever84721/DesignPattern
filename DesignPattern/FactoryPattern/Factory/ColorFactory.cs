using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.FactoryPattern.Color;
using DesignPattern.FactoryPattern.Shape;

namespace DesignPattern.FactoryPattern.Factory
{
    public class ColorFactory : AbstractFactory
    {
        public override IColor GetColor(ColorType colorType)
        {
            IColor color = new NullColor();
            switch(colorType)
            {
                case ColorType.Red:
                    color = new Red();
                    break;
                case ColorType.Green:
                    color = new Green();
                    break;
                case ColorType.Blue:
                    color = new Blue();
                    break;
            }
            return color;
        }
        public override IShape GetShape(ShapeType shapeType)
        {
            return new NullShape();
        }
    }
}
