namespace BookStore.API.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public System.DateTime Date { get; set; }
        public Book Book { get; set; }
        public User User { get; set; }
    }
}