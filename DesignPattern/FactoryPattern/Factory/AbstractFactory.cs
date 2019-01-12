using DesignPattern.FactoryPattern.Color;
using DesignPattern.FactoryPattern.Shape;

namespace DesignPattern.FactoryPattern.Factory
{
    public abstract class AbstractFactory//這邊可以改成兩個Interface
    {
        public abstract IColor GetColor(ColorType colorType);
        public abstract IShape GetShape(ShapeType shapeType);
    }
    public enum FactoryType
    {
        Shape = 0,
        Color = 1
    }
};
