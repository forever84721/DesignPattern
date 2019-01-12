using DesignPattern.FactoryPattern.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern.Factory
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(FactoryType factoryType)
        {
            AbstractFactory factory = new NullFactory();//空對象模式
            switch (factoryType)
            {
                case FactoryType.Color:
                    factory = new ColorFactory();
                    break;
                case FactoryType.Shape:
                    factory = new ShapeFactory();
                    break;
            }
            return factory;
        }
    }
}
