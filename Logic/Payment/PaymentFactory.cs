namespace MiniPOS.Logic.Payment
{
    public static class PaymentFactory
    {
        public static IPaymentStrategy CreatePayment(PaymentType type)
        {
            return type switch
            {
                PaymentType.Cash => new CashPayment(),
                PaymentType.MobileWallet => new QrPayment(),
                PaymentType.Card => new CardPayment(),
                PaymentType.QR => new QrPayment(),
                _ => throw new NotImplementedException()
            };
        }
    }
}
