using System;
using DesignPattern.FactoryPattern.Color;
using DesignPattern.FactoryPattern.Shape;

namespace DesignPattern.FactoryPattern.Factory
{
    public class NullFactory : AbstractFactory
    {
        public override IColor GetColor(ColorType colorType)
        {
            return new NullColor();
        }
        public override IShape GetShape(ShapeType shapeType)
        {
            return new NullShape();
        }
    }
}
