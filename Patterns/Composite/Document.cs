﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Document : Composite
    {
        public override string GetHtml()
        {
            var sb = new StringBuilder();

            sb.Append("<doc>");
            foreach (var item in _list)
            {
                sb.Append(item.GetHtml());
            }
            sb.Append("</doc>");

            return sb.ToString();
        }
    }
}
