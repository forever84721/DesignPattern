

namespace DesignPattern.FactoryPattern.Color
{
    public interface IColor
    {
        void Fill();
    }
    public enum ColorType
    {
        Red = 0,
        Green = 1,
        Blue = 2
    }
}
