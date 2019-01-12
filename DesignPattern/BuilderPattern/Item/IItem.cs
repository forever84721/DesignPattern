using DesignPattern.BuilderPattern.Packing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.BuilderPattern
{
    public interface IItem
    {
        string Name();
        IPacking Packing();
        int Price();
    }
}
