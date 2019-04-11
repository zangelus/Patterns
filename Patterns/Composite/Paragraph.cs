using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Paragraph:Composite
    {
        public override string GetHtml()
        {
            var sb = new StringBuilder();

            sb.Append("<para>");
            foreach (var item in _list)
            {
                sb.Append(item.GetHtml());
            }
            sb.Append("</para>");

            return sb.ToString();
        }
    }
}
