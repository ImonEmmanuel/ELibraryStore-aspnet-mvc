using ELibraryStore.Models;

namespace ELibraryStore.Data.ViewModel
{
    public class NewBookDropDownVM
    {
        public NewBookDropDownVM()
        {
            Publishers = new List<Publisher>();
            Authors = new List<Author>();
            BookStores = new List<BookStore>();
        }
        public List<Publisher> Publishers { get; set; }
        public List<Author> Authors { get; set; }
        public List<BookStore> BookStores { get; set; }
    }
}
