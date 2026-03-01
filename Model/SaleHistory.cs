namespace DrinkOrderSystem.Model
{
    public class SaleHistory
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string PaymentType { get; set; }
    }
}
