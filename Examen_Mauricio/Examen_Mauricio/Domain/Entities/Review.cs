namespace Biblioteca_Api.Domain.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; } = string.Empty;
        public int Rating { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; } = null!;
    }
}