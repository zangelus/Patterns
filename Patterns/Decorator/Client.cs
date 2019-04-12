using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Client
    {
        public decimal Order1{ get; private set; }
        public decimal Order2{ get; private set; }

        public Client()
        {
            var double_vanilla_expresso_order = new VanillaDecorator(new VanillaDecorator(new Expresso()));
            Order1 = double_vanilla_expresso_order.Cost();

            var chocolate_expresso_order = new ChocolateDecorator(new Expresso());
            Order2 = chocolate_expresso_order.Cost();
        }
    }
}
