namespace ELibraryStore.Models
{
    public class Book_Author
    {
        //Many-Many Relationship

        public int BookId { get; set; }
        public Book Book { get; set; }
        public int  AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
 