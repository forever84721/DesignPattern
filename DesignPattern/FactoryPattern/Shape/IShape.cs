﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern.Shape
{
    public interface IShape
    {
        void Draw();
    }
    public enum ShapeType
    {
        Circle = 0,
        Rectangle = 1,
        Square = 2
    }
}
