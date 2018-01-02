using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTProjekt.Model
{
    public interface IAggregate
    {
        CarByCompanyIterator CreateIterator(string company);
    }
}
