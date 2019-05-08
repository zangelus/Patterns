using Factory.API;

namespace Factory.Color
{
    class Blue : IColor
    {
        public string ColorName { get; private set; }

        internal Blue()
        {
            ColorName = "Blue";
        }
    }
}
