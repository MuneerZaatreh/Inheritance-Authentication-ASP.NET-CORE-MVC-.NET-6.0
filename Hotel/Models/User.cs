namespace Hotel.Models
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        public int Level { get; set; } = 2;
        public int IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
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
