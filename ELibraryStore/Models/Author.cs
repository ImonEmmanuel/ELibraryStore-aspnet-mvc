using ELibraryStore.Data.Base;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ELibraryStore.Models
{

    public class Author : IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        //[StringLength(5000)]
        public string ProfilePictureUrl { get; set; }

        [Display(Name = "FullName")]
        [Required(ErrorMessage = "FullName is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name Length should be more that 3 and less than 50")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "A Short Biography is Needed")]
        //[StringLength(5000)]
        public string Biography { get; set; }

        public List<Book_Author> Book_Authors { get; set; }
    }
}






