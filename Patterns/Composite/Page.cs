using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Page:Composite
    {
        public override string GetHtml()
        {
            var sb = new StringBuilder();

            sb.Append("<pag>");
            foreach (var item in _list)
            {
                sb.Append(item.GetHtml());
            }
            sb.Append("</pag>");

            return sb.ToString();
        }
    }
}
