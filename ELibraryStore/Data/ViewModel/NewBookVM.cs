using ELibraryStore.Data.Base;
using ELibraryStore.Data.Enum;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ELibraryStore.Data.ViewModel
{ 
    public class NewBookVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [DisplayName("Book Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is Required")]
        [DisplayName("Book Description")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Book Image Url is Required")]
        [DisplayName("Book Image URL")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Price of Book is Required")]
        [DisplayName("Price in Dollar ($)")]
        public double Price { get; set; }

        [DisplayName("Book Category")]
        [Required(ErrorMessage = "Book Category is Required")]
        public BookCategory BookCategory { get; set; }


        [DisplayName("Edition of Book")]
        public string BookEdition { get; set; }

        [DisplayName("Date Added to Store")]
        [Required(ErrorMessage = "Date Added to Store is Required")]
        public DateTime DateAdded { get; set; }

        [DisplayName("Book Preview URL")]
        public string BookUrl { get; set; }

        [DisplayName("Select Author")]
        [Required(ErrorMessage = "Author is Required")]
        public List<int> AuthorId { get; set; }

        [DisplayName("Select a BookStore")]
        [Required(ErrorMessage = "BookStore is Required")]
        public int BookStoreId { get; set; }

        [DisplayName("Select a Publisher")]
        [Required(ErrorMessage = "Book Publisher is Required")]
        public int PublisherId { get; set; }

    }
}
