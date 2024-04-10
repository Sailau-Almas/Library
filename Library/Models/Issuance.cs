namespace Library.Models
{
    public class Issuance
    {
        public int Id { get; set; }
        public int BookId {  get; set; }
        public Book Book { get; set; }
        public DateTime IssuedDate { get; set; }
        public bool Returned {  get; set; }
    }
}
