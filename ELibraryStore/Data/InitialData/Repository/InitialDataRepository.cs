using ELibraryStore.Models;

namespace ELibraryStore.Data.Repository
{
    public class InitialDataRepository : IInitialDataRepository
    {
        private readonly ApplicationDbContext _context;

        public InitialDataRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task LoadAuthorAsync(List<Author> author)
        {
            foreach (var singleAuthor in author)
            {
                await _context.Authors.AddRangeAsync(singleAuthor);
                await _context.SaveChangesAsync();
            }
        }

        public async Task LoadBookAsync(List<Book> book)
        {
            foreach (var singleBook in book)
            {
                await _context.Books.AddRangeAsync(singleBook);
                await _context.SaveChangesAsync();
            }
        }
        public async Task LoadBookStoreAsync(List<BookStore> bookStores)
        {
            foreach (var singleStore in bookStores)
            {
                await _context.BookStores.AddRangeAsync(singleStore);
                await _context.SaveChangesAsync();
            }
        }

        public async Task LoadBook_AuthorAsync(List<Book_Author> book_Authors)
        {
            foreach (var book_Author in book_Authors)
            {
                await _context.Book_Authors.AddRangeAsync(book_Author);
                await _context.SaveChangesAsync();
            }
        }

        public async Task LoadPublisherAsync(List<Publisher> publishers)
        {
            foreach (var publisher in publishers)
            {
                await _context.Publishers.AddRangeAsync(publisher);
                await _context.SaveChangesAsync();
            }
        }

    }
}
