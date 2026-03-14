namespace MiniPOS.Logic.Payment
{
    public interface IPaymentStrategy
    {
        bool Pay(decimal amount);
    }
}
