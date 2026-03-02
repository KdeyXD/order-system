using DecoratorDrink.Model;
namespace DecoratorDrink.Logic.Decotators
{
    public class BasicDrink : IDrink
    {
        public Drink Drink { get; set; }
        public BasicDrink(Drink drink) { Drink = drink; }
        public string GetDescription() => Drink.Name;
        public decimal GetPrice() => Drink.Price;
    }
}
