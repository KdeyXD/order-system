using DecoratorDrink.Logic.Decotators;
namespace DrinkOrderSystem.Logic.Decotators
{
    public class CreamDecorator  : DrinkDecorator
    {
        public CreamDecorator(IDrink drink) : base(drink) { }
        public override string GetDescription() => drink.GetDescription() + ", Cream";
        public override decimal GetPrice() => drink.GetPrice() + 0.50m;
    }
}
