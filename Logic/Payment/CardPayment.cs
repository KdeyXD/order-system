namespace MiniPOS.Logic.Payment
{
    public class CardPayment : IPaymentStrategy
    {
        public bool Pay(decimal amount)
        {
            MessageBox.Show($"Paid ${amount:0.00} by Card");
            return true;
        }
    }
}
