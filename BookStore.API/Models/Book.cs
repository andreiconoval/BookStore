using System.ComponentModel.DataAnnotations;

namespace BookStore.API.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genres { get; set; }
        public double Price { get; set; }

    }
}