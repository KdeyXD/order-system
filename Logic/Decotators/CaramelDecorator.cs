using DecoratorDrink.Logic.Decotators;
namespace DrinkOrderSystem.Logic.Decotators
{
    public class CaramelDecorator : DrinkDecorator
    {
        public CaramelDecorator(IDrink drink) : base(drink) { }
        public override string GetDescription() => drink.GetDescription() + ", Caramel";
        public override decimal GetPrice() => drink.GetPrice() + 0.75m;
    }
}
