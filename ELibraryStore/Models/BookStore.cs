using System.ComponentModel.DataAnnotations;
using ELibraryStore.Data.Base;

namespace ELibraryStore.Models
{
    public class BookStore : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Book Store Logo")]
        [Required(ErrorMessage = "Book Store Logo URL is required")]
        public string Logo { get; set; }
        [Display(Name = "BookStore Name")]
        [Required(ErrorMessage = "Book Store Name is required")]
        public string Name { get; set; }
        [Display(Name = "Book Store Description")]
        [Required(ErrorMessage = "Description of Book Store is required")]
        public string Description { get; set; }

        //Relationships
        public List<Book> Books { get; set; }
    }
}
