namespace DecoratorDrink.Logic.Decotators
{
    public class MilkDecorator : DrinkDecorator
    {
        public MilkDecorator(IDrink drink) : base(drink) { }

        public override string GetDescription() => drink.GetDescription() + ", Milk";
        public override decimal GetPrice() => drink.GetPrice() + 0.50m;
    }
}
