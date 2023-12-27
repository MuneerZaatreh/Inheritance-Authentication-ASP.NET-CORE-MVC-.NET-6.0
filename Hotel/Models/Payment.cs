using System.ComponentModel.DataAnnotations;

namespace woodStore.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int StoreId { get; set; }
        public int UserId { get; set; }
        [Required]
        public string CardNumber { get; set; }
        [Required]
        public string CardHolderName { get; set; }
        [Required]
        public string CardHolderId { get; set; }
        [Required]
        public string ExpiryDate { get; set; }
        [Required]
        public string Cvv { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
