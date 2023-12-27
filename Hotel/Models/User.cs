namespace Hotel.Models
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PostCode { get; set; }
        public string ImageUrl { get; set; }
        public string Status { get; set; }
        public int Level { get; set; } = 2;
        public int IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdate { get; set; }
        public User()
        {
        }
        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
}
