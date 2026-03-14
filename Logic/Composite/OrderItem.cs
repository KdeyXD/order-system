using DecoratorDrink.Logic.Decotators;
namespace DecoratorDrink.Logic.Composite
{
    public class OrderItem : IOrder
    {
        public IDrink Drink { get; set; }
        public OrderItem(IDrink drink, int quantity)
        {
            Drink = drink;
            Quantity = quantity;
        }

        public string Name => Drink.GetDescription();
        public int Quantity { get; set; }

        public decimal UnitPrice => Drink.GetPrice();
        public decimal Total => UnitPrice * Quantity;

        public decimal GetTotalPrice() => Total;
        public string GetDescription() => Drink.GetDescription();
        public decimal GetUnitPrice() => Drink.GetPrice();
    }
}
