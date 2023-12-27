namespace woodStore.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Product
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public double DiscountPercentage  { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public string Status { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdate { get; set; }

    }
}
