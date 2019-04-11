using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class ItemType1:Leaf
    {
        private string _msg;

        public ItemType1(string msg)
        {
            _msg = msg;
        }

        public override string GetHtml()
        {
            return "<il>" + _msg + "</il>";
        }
    }
}
