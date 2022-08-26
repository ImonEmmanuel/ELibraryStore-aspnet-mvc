using ELibraryStore.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace ELibraryStore.Models
{
    public class Publisher : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture URL is required")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Name of Publishing House required")]
        public string FullName { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description of Publisher is required")]
        public string Description { get; set; }
        //Relationships
        public List<Book> Books { get; set; }
    }
}
