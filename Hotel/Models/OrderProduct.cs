namespace woodStore.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public double DiscountPercentage { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
