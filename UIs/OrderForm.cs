using DecoratorDrink.Logic.Composite;
using DecoratorDrink.Model;
using DecoratorDrink.Service;
using MiniPOS.Service;

namespace DrinkOrderSystem.UIs
{
    public partial class OrderForm : Form
    {
        #region Fields

        private readonly DrinkService _drinkService;
        private readonly Order _order;
        private readonly Form _mainForm;
        private List<Drink> _allDrinks;

        #endregion

        #region Constructor

        public OrderForm(Form mainForm)
        {
            InitializeComponent();

            _drinkService = new DrinkService();
            _order = new Order();
            _mainForm = mainForm;
        }

        #endregion

        #region Form Events

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadDrinks();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            _mainForm.Show();
        }

        #endregion

        #region Order Actions

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!HasSelectedDrink()) return;

            var selectedDrink = GetSelectedDrink();

            using var toppingForm = new ToppingForm(selectedDrink);

            if (toppingForm.ShowDialog() == DialogResult.OK)
            {
                _order.Add(toppingForm.CreatedOrderItem);
                RefreshOrderGrid();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!HasSelectedOrderItem()) return;

            var selectedItem = GetSelectedOrderItem();
            if (selectedItem == null) return;

            using var toppingForm = new ToppingForm(selectedItem);

            if (toppingForm.ShowDialog() == DialogResult.OK)
            {
                _order.Remove(selectedItem);
                _order.Add(toppingForm.CreatedOrderItem);
                RefreshOrderGrid();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!HasSelectedOrderItem()) return;

            var selectedItem = GetSelectedOrderItem();
            if (selectedItem == null) return;

            if (!ConfirmAction("Remove selected item?", "Confirm Remove"))
                return;

            _order.Remove(selectedItem);
            RefreshOrderGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (!ConfirmAction("Clear the entire order?", "Clear Order"))
                return;

            _order.Clear();
            RefreshOrderGrid();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var totalAmount = _order.GetTotalPrice();

            if (totalAmount <= 0)
            {
                MessageBox.Show("Order is empty!");
                return;
            }

            var orderService = new OrderService();
            int orderId = orderService.SaveOrder(_order);

            using var paymentForm = new PaymentForm(orderId, totalAmount);

            if (paymentForm.ShowDialog() == DialogResult.OK)
            {
                _order.Clear();
                RefreshOrderGrid();
            }
        }

        #endregion

        #region Search

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            var filtered = _allDrinks
                .Where(d => d.Name.ToLower().Contains(keyword))
                .ToList();

            dgvDrinks.DataSource = null;
            dgvDrinks.DataSource = filtered;
        }

        #endregion

        #region Private Helpers

        private void LoadDrinks()
        {
            _allDrinks = _drinkService.GetAllDrinks();
            dgvDrinks.DataSource = _allDrinks;
        }

        private void RefreshOrderGrid()
        {
            var displayList = _order.Items
                                    .OfType<OrderItem>()
                                    .ToList();

            dgvOrder.DataSource = null;
            dgvOrder.DataSource = displayList;

            if (dgvOrder.Columns["Drink"] != null)
                dgvOrder.Columns["Drink"].Visible = false;

            lblTotal.Text = $"Total: ${_order.GetTotalPrice():0.00}";
        }

        private bool HasSelectedDrink()
            => dgvDrinks.SelectedRows.Count > 0;

        private bool HasSelectedOrderItem()
            => dgvOrder.SelectedRows.Count > 0;

        private Drink GetSelectedDrink()
            => dgvDrinks.SelectedRows[0].DataBoundItem as Drink;

        private OrderItem GetSelectedOrderItem()
            => dgvOrder.SelectedRows[0].DataBoundItem as OrderItem;

        private bool ConfirmAction(string message, string title)
        {
            return MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) == DialogResult.Yes;
        }

        #endregion
    }
}