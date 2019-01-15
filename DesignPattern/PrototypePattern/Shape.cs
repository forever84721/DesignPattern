using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PrototypePattern
{
    public abstract class Shape 
    {
        public int Id { get; set; }
        protected ShapeType ShapeType;
        public abstract void Draw();
        public ShapeType GetShapeType()
        {
            return ShapeType;
        }
        public Shape Clone()
        {
            return (Shape)this.MemberwiseClone();
        }
    }
    public enum ShapeType
    {
        Circle = 0,
        Rectangle = 1,
        Square = 2
    }
}
