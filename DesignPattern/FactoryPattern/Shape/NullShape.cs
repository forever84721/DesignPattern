using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern.Shape
{
    class NullShape : IShape
    {
        public void Draw()
        {
            //throw new NotImplementedException();
        }
    }
}
