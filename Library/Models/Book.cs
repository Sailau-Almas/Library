using System.Security.Cryptography.X509Certificates;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
    }
}
