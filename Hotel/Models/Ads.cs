using System.ComponentModel.DataAnnotations;

namespace woodStore.Models
{
    public class Ads
    {
        public int Id { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public string Status { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdate { get; set; }
    }
}
