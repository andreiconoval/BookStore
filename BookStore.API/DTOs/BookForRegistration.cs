using BookStore.API.Models;

namespace BookStore.API.DTOs
{
    public class BookForRegistration
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genres { get; set; }
        public double Price { get; set; }

        public Book Convert()
        {
            return new Book()
            {
                Id = this.Id,
                Name = this.Name.Trim(),
                Author = this.Author.Trim(),
                Genres = this.Genres.Trim(),
                Price = this.Price
            };
        }
    }
}