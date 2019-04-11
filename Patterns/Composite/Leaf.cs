using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Leaf : IComponent
    {
        public virtual string GetHtml()
        {
            throw new NotImplementedException();
        }
    }
}
