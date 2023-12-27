
namespace woodStore.Models
{
    using System.ComponentModel.DataAnnotations;
    public class Category
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string Status { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdate { get; set; } 

    }
}
