using DrinkOrderSystem.Services;

namespace DrinkOrderSystem.UIs
{
    public partial class SaleHistoryForm : Form
    {
        private Form _mainForm;
        private readonly SaleService _saleService;
        public SaleHistoryForm(Form mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _saleService = new SaleService();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            _mainForm.Show();
        }

        private void SaleHistoryForm_Load(object sender, EventArgs e)
        {
            var sales = _saleService.GetSalesHistory();
            dgvSales.DataSource = sales;
        }
    }
}
