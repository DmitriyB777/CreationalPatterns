using CreationalPatterns.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Library.Classes
{
    public class Shape : IMyCloneable<Shape>, ICloneable
    {
        public virtual Shape Clone()
        {
            return (Shape)MemberwiseClone();
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
