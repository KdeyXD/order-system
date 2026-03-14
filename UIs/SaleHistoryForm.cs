using DrinkOrderSystem.Services;

namespace DrinkOrderSystem.UIs
{
    public partial class SaleHistoryForm : Form
    {
        private Form _mainForm;
        private bool _isMainForm = false; // Flag to indicate if this is the main form  
        private readonly SaleService _saleService;
        private BindingSource _bindingSource = new BindingSource();
        public SaleHistoryForm(Form mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _saleService = new SaleService();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _isMainForm = true;
            _mainForm.Show();
            this.Close();
        }

        private void SaleHistoryForm_Load(object sender, EventArgs e)
        {
            var sales = _saleService.GetSalesHistory();
            _bindingSource.DataSource = sales;
            dgvSales.DataSource = _bindingSource;
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.SelectedItem == null) return;

            var selection = cmbFilter.SelectedItem.ToString();
            var allSales = _saleService.GetSalesHistory();

            IEnumerable<DrinkOrderSystem.Model.SaleHistory> filtered = allSales;

            switch (selection)
            {
                case "Today":
                    var today = DateTime.Today;
                    filtered = allSales.Where(s => s.OrderDate.Date == today);
                    break;
                case "This Week":
                    var startOfWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek);
                    filtered = allSales.Where(s => s.OrderDate.Date >= startOfWeek);
                    break;
                case "This Month":
                    var startOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    filtered = allSales.Where(s => s.OrderDate.Date >= startOfMonth);
                    break;
                default:
                    // "All" or unknown
                    filtered = allSales;
                    break;
            }

            _bindingSource.DataSource = filtered.ToList();
        }

        private void SaleHistoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isMainForm && e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();   // Only exit if NOT logging out
            }
        }
    }
}
