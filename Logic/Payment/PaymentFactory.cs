using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPOS.Logic.Payment
{
    public static class PaymentFactory
    {
        public static IPaymentStrategy CreatePayment(PaymentType type)
        {
            return type switch
            {
                PaymentType.Cash => new CashPayment(),
                PaymentType.Card => new CardPayment(),
                PaymentType.QR => new QrPayment(),
                _ => throw new NotImplementedException()
            };
        }
    }
}
