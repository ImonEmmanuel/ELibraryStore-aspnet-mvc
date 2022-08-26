using ELibraryStore.Data.Base;
using ELibraryStore.Data.ViewModel;
using ELibraryStore.Models;
using Microsoft.EntityFrameworkCore;

namespace ELibraryStore.Data.Services.Implementation
{
    public class BookService : EntityBaseRepository<Book>, IBookService
    {
        private readonly ApplicationDbContext _context;
        public BookService(ApplicationDbContext context)
            :base(context)
        {
            _context = context;
        }

        public async Task AddNewBookAsync(NewBookVM newBookVM)
        {
            Book book = new Book()
            {
                Name = newBookVM.Name,
                Description = newBookVM.Description,
                Price = newBookVM.Price,
                ImageUrl = newBookVM.ImageUrl,
                BookStoreId = newBookVM.BookStoreId,
                DateAdded = newBookVM.DateAdded,
                BookEdition = newBookVM.BookEdition,
                BookUrl = newBookVM.BookUrl,
                PublisherId = newBookVM.PublisherId,
                BookCategory = newBookVM.BookCategory,
            };
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();

            //Add Movie Actors
            foreach (var authorID in newBookVM.AuthorId)
            {
                var newBookAuthor = new Book_Author()
                {
                    AuthorId = authorID,
                    BookId = book.Id,
                };
                await _context.Book_Authors.AddAsync(newBookAuthor);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Book> GetBookbyIdAsync(int id)
        {
            var data = await _context.Books.Include(b => b.BookStore)
                .Include(p => p.Publisher)
                .Include(a => a.Book_Authors).ThenInclude(aa => aa.Author)
                .FirstOrDefaultAsync(n => n.Id == id);
            return data;
        }

        public async Task<NewBookDropDownVM> GetNewBookDropDownValue()
        {
            var response = new NewBookDropDownVM();
            response.Authors = await _context.Authors.OrderBy(n => n.FullName).ToListAsync();
            response.Publishers = await _context.Publishers.OrderBy(n => n.FullName).ToListAsync();
            response.BookStores = await _context.BookStores.OrderBy(n => n.Name).ToListAsync();
            return response;
        }

        public async Task UpdateBookAsync(NewBookVM newBookVM)
        {
            var dbBook = await _context.Books.FirstOrDefaultAsync(n => n.Id == newBookVM.Id);

            if(dbBook != null)
            {
                dbBook.Name = newBookVM.Name;
                dbBook.Description = newBookVM.Description;
                dbBook.Price = newBookVM.Price;
                dbBook.ImageUrl = newBookVM.ImageUrl;
                dbBook.BookStoreId = newBookVM.BookStoreId;
                dbBook.DateAdded = newBookVM.DateAdded;
                dbBook.BookEdition = newBookVM.BookEdition;
                dbBook.BookUrl = newBookVM.BookUrl;
                dbBook.PublisherId = newBookVM.PublisherId;
                dbBook.BookCategory = newBookVM.BookCategory;
                await _context.SaveChangesAsync();
            }
            //Remove existing actors
            var existingBookDb = _context.Book_Authors.Where(n => n.BookId == newBookVM.Id).ToList();
            _context.Book_Authors.RemoveRange(existingBookDb);
            await _context.SaveChangesAsync();

            //Add Movie Actors
            foreach (var authorID in newBookVM.AuthorId)
            {
                var newBookAuthor = new Book_Author()
                {
                    AuthorId = authorID,
                    BookId = newBookVM.Id,
                };
                await _context.Book_Authors.AddAsync(newBookAuthor);
                await _context.SaveChangesAsync();
            }
        }
    }
}
