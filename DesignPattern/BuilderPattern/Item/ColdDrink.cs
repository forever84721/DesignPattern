using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.BuilderPattern.Packing;

namespace DesignPattern.BuilderPattern.Item
{
    public abstract class ColdDrink : IItem
    {
        public abstract string Name();
        public IPacking Packing()
        {
            return new Bottle();
        }
        public abstract int Price();
    }
}
