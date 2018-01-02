using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public interface IIterator
    {
        Car First();
        bool HasNext();
        Car Next();
        Car CurrentItem();
        bool Remove();
    }
}
