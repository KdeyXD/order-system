namespace DecoratorDrink.Logic.Decotators
{
    public abstract class DrinkDecorator : IDrink
    {
        protected IDrink drink;
        public DrinkDecorator(IDrink drink) { this.drink = drink; }
        public virtual string GetDescription() => drink.GetDescription() + " +";
        public virtual decimal GetPrice() => drink.GetPrice();
        public IDrink GetInnerDrink() => drink;
    }
}
