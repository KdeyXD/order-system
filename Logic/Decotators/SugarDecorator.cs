namespace DecoratorDrink.Logic.Decotators
{
    public class SugarDecorator : DrinkDecorator
    {
        public SugarDecorator(IDrink drink) : base(drink) { }
        public override string GetDescription() => drink.GetDescription() + ", Sugar";
        public override decimal GetPrice() => drink.GetPrice() + 0.25m;
    }
}
