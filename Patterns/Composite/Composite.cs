using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Composite : IComponent
    {
        protected IList<IComponent> _list = new List<IComponent>();

        public virtual string GetHtml()
        {
            var sb = new StringBuilder();

            sb.Append("<ul>");
            foreach (var item in _list)
            {
                sb.Append(item.GetHtml());
            }
            sb.Append("</ul>");

            return sb.ToString();
        }

        public void AddChild(IComponent component)
        {
            _list.Add(component);
        }

        public void RemoveChild(IComponent component)
        {
            _list.Remove(component);
        }
    }
}
