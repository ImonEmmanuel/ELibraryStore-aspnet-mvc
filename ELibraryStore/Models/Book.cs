using ELibraryStore.Data.Base;
using ELibraryStore.Data.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELibraryStore.Models
{
    public class Book : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public BookCategory BookCategory { get; set; }
        
        public string BookEdition { get; set; }
        public DateTime DateAdded { get; set; }
        public string BookUrl { get; set; }

        public List<Book_Author> Book_Authors { get; set; }

        public int? BookStoreId { get; set; }
        [ForeignKey("BookStoreId")]
        public BookStore BookStore { get; set; }

        public int? PublisherId { get; set; }
        [ForeignKey("PublisherId")]
        public Publisher Publisher { get; set; }

    }
}
