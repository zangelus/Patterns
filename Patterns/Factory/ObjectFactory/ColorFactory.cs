using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.API;
using Factory.Color;

namespace Factory.ObjectFactory
{
    public class ColorFactory
    {
        public IColor Create(ColorType color)
        {
            IColor instance;

            switch (color)
            {
                case ColorType.Blue:
                    instance = new Blue();
                    break;
                case ColorType.Red:
                    instance = new Red();
                    break;
                default:
                    instance = null;
                    break;
            }

            return instance;
        }
    }
}
