using MiniPOS.Data;
using MiniPOS.Logic.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPOS.Service
{
    public class PaymentService
    {
        private readonly PaymentRepository _paymentRepository;

        public PaymentService()
        {
            _paymentRepository = new PaymentRepository();
        }

        public bool ProcessPayment(int orderId, PaymentType type, decimal amount)
        {
            // Create strategy using factory
            var strategy = PaymentFactory.CreatePayment(type);

            // Execute payment
            bool success = strategy.Pay(amount);

            if (!success)
                return false;

            // Save payment record
            _paymentRepository.InsertPayment(orderId, type.ToString(), amount);

            return true;
        }
    }
}
