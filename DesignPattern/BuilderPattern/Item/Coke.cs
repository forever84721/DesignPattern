using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPattern.Item
{
    public class Coke : ColdDrink
    {
        public override string Name()
        {
            return "Coke";
        }
        public override int Price()
        {
            return 20;
        }
    }
}
