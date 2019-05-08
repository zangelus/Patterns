using Factory.API;

namespace Factory.Color
{
    class Red : IColor
    {
        public string ColorName { get; private set; }

        internal Red()
        {
            ColorName = "Red";
        }
    }
}
