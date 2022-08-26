using ELibraryStore.Models;

namespace ELibraryStore.Data.Repository
{
    public interface IInitialDataRepository
    {
        Task LoadAuthorAsync(List<Author> author);
        Task LoadBookAsync(List<Book> book);
        Task LoadBook_AuthorAsync(List<Book_Author> book_Author);
        Task LoadBookStoreAsync(List<BookStore> bookStore);
        Task LoadPublisherAsync(List<Publisher> publisher);
    }
}
