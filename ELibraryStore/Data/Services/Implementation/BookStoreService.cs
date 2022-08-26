using ELibraryStore.Data.Base;
using ELibraryStore.Models;

namespace ELibraryStore.Data.Services.Implementation
{
    public class BookStoreService : EntityBaseRepository<BookStore>, IBookStoreService
    {
        public BookStoreService(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
