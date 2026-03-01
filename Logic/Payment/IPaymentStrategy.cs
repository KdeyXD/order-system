using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniPOS.Logic.Payment
{
    public interface IPaymentStrategy
    {
        bool Pay(decimal amount);
    }
}
