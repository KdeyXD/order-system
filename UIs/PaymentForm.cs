

using MiniPOS.Logic.Payment;
using MiniPOS.Service;

namespace DrinkOrderSystem.UIs
{
    public partial class PaymentForm : Form
    {
        private readonly decimal _totalAmount;
        private readonly int _orderId;
        private readonly PaymentService _paymentService;
        public PaymentForm(int orderId, decimal totalAmount)
        {
            InitializeComponent();
            _orderId = orderId;
            _totalAmount = totalAmount;
            _paymentService = new PaymentService();

            lblTotalAmount.Text = $"Total: ${_totalAmount:0.00}";
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            PaymentType selectedType;

            if (rbCash.Checked)
                selectedType = PaymentType.Cash;
            else if (rbCreditCard.Checked)
                selectedType = PaymentType.Card;
            else
                selectedType = PaymentType.QR;

            bool success = _paymentService.ProcessPayment(
                _orderId,
                selectedType,
                _totalAmount);

            if (success)
            {
                MessageBox.Show("Payment successful!");
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Payment failed!");
            }
        }
    }
}
