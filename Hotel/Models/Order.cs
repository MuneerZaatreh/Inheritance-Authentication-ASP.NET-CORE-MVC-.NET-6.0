using System.ComponentModel.DataAnnotations;

namespace woodStore.Models
{
    public class Order
    {

        public int Id { get; set; }
        public int Number { get; set; }
        public int StoreId { get; set; }
        public int UserId { get; set; }
        public double Total { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdate { get; set; }
    }
}
