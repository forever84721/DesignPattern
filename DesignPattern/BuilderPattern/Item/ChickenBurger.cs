using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPattern.Item
{
    public class ChickenBurger : Burger
    {
        public override string Name()
        {
            return "ChickenBurger";
        }
        public override int Price()
        {
            return 40;
        }
    }
}
