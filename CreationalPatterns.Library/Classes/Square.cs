using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Library.Classes
{
    public class Square : Rectangle
    {
        public Square(double side) : base(side, side) { }

        public override Shape Clone()
        {
            return new Square(Width);
        }
    }
}
