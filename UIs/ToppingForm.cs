using DecoratorDrink.Logic.Composite;
using DecoratorDrink.Logic.Decotators;
using DecoratorDrink.Model;
using DrinkOrderSystem.Logic.Decotators;

namespace DrinkOrderSystem.UIs
{
    public partial class ToppingForm : Form
    {
        private Drink _selectedDrink;

        public OrderItem CreatedOrderItem { get; private set; }

        public ToppingForm(Drink drink)
        {
            InitializeComponent();

            _selectedDrink = drink;
            lblDrinkName.Text = drink.Name;
        }

        public ToppingForm(OrderItem orderItem)
        {
            InitializeComponent();

            // Extract base drink
            IDrink drink = orderItem.Drink;

            while (drink is DrinkDecorator decorator)
            {
                drink = decorator.GetInnerDrink();
            }

            if (drink is BasicDrink basic)
            {
                _selectedDrink = basic.Drink;
            }

            lblDrinkName.Text = _selectedDrink.Name;
            numericQty.Value = orderItem.Quantity;

            // Detect toppings from description
            string description = orderItem.GetDescription();

            if (description.Contains("Milk"))
                chkMilk.Checked = true;

            if (description.Contains("Sugar"))
                chkSugar.Checked = true;
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            IDrink drink = new BasicDrink(_selectedDrink);

            if (chkMilk.Checked)
                drink = new MilkDecorator(drink);

            if (chkSugar.Checked)
                drink = new SugarDecorator(drink);

            if(chkCream.Checked)
                drink = new CreamDecorator(drink);

            if(chkCaramel.Checked)
                drink = new CaramelDecorator(drink);

            int qty = (int)numericQty.Value;

            CreatedOrderItem = new OrderItem(drink, qty);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}