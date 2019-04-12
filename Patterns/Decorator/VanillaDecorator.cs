namespace Decorator
{
    class VanillaDecorator : AdditionDecorator
    {
        public VanillaDecorator(Beverage baseBeverage) : base(baseBeverage){}

        public override decimal Cost()
        {
            return _baseBeverage.Cost() + 1.5M;
        }
    }
}
