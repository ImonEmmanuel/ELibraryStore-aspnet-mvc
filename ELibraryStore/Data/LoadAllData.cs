using ELibraryStore.Data.InitialData;
using ELibraryStore.Data.Repository;

namespace ELibraryStore.Data
{
    public class LoadAllData 
    {
        //private readonly IInitialDataRepository _repository;
        //private readonly ApplicationDbContext _context;

        public static void LoadData(ApplicationDbContext _context)
        {
            InitialDataRepository _repository = new InitialDataRepository(_context);

            _context.Database.EnsureCreated();

            //Author
            if (!_context.Authors.Any())
            {
                AuthorData author = new AuthorData();
                var authorList = author.GetAuthors();
                _repository.LoadAuthorAsync(authorList);
            }

            //Books
            if (!_context.Books.Any())
            {
                BookData bookData = new BookData();
                var bookList = bookData.GetBooks();
                _repository.LoadBookAsync(bookList);
            }

            //BookStore
            if (!_context.BookStores.Any())
            {
                BookStoreData bookStoreData = new BookStoreData();
                var bookList = bookStoreData.GetBookStores();
                _repository.LoadBookStoreAsync(bookList);
            }

            //Book_Author
            if (!_context.Book_Authors.Any())
            {
                Book_AuthorData book_AuthorData= new Book_AuthorData();
                var book_AuthorsList = book_AuthorData.GetBook_Authors();
                _repository.LoadBook_AuthorAsync(book_AuthorsList);
            }

            //Publisher
            if (!_context.Publishers.Any()) 
            {
                PublisherData publisher = new PublisherData();
                var newPublisher = publisher.GetData();
                _repository.LoadPublisherAsync(newPublisher);
            }

        }
    }
}