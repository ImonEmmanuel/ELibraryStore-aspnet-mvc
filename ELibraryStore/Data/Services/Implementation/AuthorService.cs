using ELibraryStore.Data.Base;
using ELibraryStore.Models;
using Microsoft.EntityFrameworkCore;

namespace ELibraryStore.Data.Services.Implementation
{
    public class AuthorService: EntityBaseRepository<Author>, IAuthorService
    {
        public AuthorService(ApplicationDbContext context)
            :base(context)
        {
        }
    }
}
