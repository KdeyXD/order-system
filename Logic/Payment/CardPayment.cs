using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
