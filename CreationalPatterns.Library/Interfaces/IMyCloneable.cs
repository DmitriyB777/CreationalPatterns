using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns.Library.Interfaces
{
    public interface IMyCloneable<T>
    {
        T Clone();
    }
}
