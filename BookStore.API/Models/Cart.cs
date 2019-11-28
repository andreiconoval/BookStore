using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Models
{
    public class Cart
    {
        public int Id { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public int UserId { get; set; }

        public Book Book { get; set; }
        public User User {get; set;}


    }
}