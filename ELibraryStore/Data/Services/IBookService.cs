using ELibraryStore.Data.Base;
using ELibraryStore.Models;
using ELibraryStore.Data.ViewModel;

namespace ELibraryStore.Data.Services
{
    public interface IBookService : IEntityBaseRepository<Book>
    {
        Task<Book> GetBookbyIdAsync(int id);
        Task<NewBookDropDownVM> GetNewBookDropDownValue();
        Task AddNewBookAsync(NewBookVM newBookVM);
        Task UpdateBookAsync(NewBookVM newBookVM);

    }
}
