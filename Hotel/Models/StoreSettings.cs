using System.ComponentModel.DataAnnotations;

namespace woodStore.Models
{
    public class StoreSettings
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string WorkTime { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdate { get; set; }
    }
}
