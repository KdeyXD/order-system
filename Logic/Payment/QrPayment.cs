namespace MiniPOS.Logic.Payment
{
    public class QrPayment : IPaymentStrategy
    {
        public bool Pay(decimal amount)
        {
            // Simulate showing a QR code and waiting for confirmation
            MessageBox.Show($"Present QR code for ${amount:0.00} payment (simulated)");
            return true;
        }
    }
}
