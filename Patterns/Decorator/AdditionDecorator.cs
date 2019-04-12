namespace Decorator
{
    abstract class AdditionDecorator:Beverage
    {
        protected Beverage _baseBeverage;

        public AdditionDecorator(Beverage baseBeverage)
        {
            _baseBeverage = baseBeverage;
        }
    }
}
