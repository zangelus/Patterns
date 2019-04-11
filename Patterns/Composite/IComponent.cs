using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public interface IComponent
    {
        //void AddChild(IComponent component);
        //void RemoveChild(IComponent component);
        string GetHtml();
    }
}
