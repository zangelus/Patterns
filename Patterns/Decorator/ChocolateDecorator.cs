namespace Decorator
{
    class ChocolateDecorator:AdditionDecorator
    {
        public ChocolateDecorator(Beverage beverage) : base(beverage){}

        public override decimal Cost()
        {
            return _baseBeverage.Cost() + 1.8M;
        }
    }
}
