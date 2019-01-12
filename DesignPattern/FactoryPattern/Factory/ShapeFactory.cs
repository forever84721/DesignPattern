using System;
using DesignPattern.FactoryPattern.Color;
using DesignPattern.FactoryPattern.Shape;

namespace DesignPattern.FactoryPattern.Factory
{
    public class ShapeFactory : AbstractFactory
    {
        public override IColor GetColor(ColorType colorType)
        {
            return new NullColor();
        }
        public override IShape GetShape(ShapeType shapeType)
        {
            IShape shape = new NullShape();
            switch (shapeType)
            {
                case ShapeType.Circle:
                    shape = new Circle();
                    break;
                case ShapeType.Rectangle:
                    shape = new Rectangle();
                    break;
                case ShapeType.Square:
                    shape = new Square();
                    break;
            }
            return shape;
        }
    }
}
