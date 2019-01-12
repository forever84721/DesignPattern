using DesignPattern.BuilderPattern.Packing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPattern.Item
{
    public class VegBurger : Burger
    {
        public override string Name()
        {
            return "VegBurger";
        }
        public override int Price()
        {
            return 30;
        }
    }
}
