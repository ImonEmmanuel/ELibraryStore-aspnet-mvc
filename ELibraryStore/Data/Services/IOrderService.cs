using ELibraryStore.Models;

namespace ELibraryStore.Data.Services
{
    public interface IOrderService
    {
        Task StoreOrderAsync(List<ShopingCartItem> items, string userId, string userEmailAddress);
        Task<List<Order>> GetOrdersByUserIdAsync(string userId);
    }
}
