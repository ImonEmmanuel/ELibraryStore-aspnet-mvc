using ELibraryStore.Data.Base;
using ELibraryStore.Models;

namespace ELibraryStore.Data.Services.Implementation
{
    public class PublisherService : EntityBaseRepository<Publisher>, IPublisherService
    {
        public PublisherService(ApplicationDbContext context)
            : base(context)
        {
        }
    }
}
