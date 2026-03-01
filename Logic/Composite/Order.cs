namespace DecoratorDrink.Logic.Composite
{
    public class Order : IOrder
    {
        private readonly List<IOrder> _items = new();
        public List<IOrder> Items => _items;
        public void Add(IOrder component) => _items.Add(component);
        public void Remove(IOrder component) => _items.Remove(component);
        public void Clear() => _items.Clear();
        public decimal GetTotalPrice()
        {
            decimal total = 0;
            foreach (var item in _items)
            {
                total += item.GetTotalPrice();
            }
            return total;
        }
    }
}
