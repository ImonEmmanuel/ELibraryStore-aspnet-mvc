using ELibraryStore.Models;
using Microsoft.EntityFrameworkCore;

namespace ELibraryStore.Data.Services.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;
        public OrderService(ApplicationDbContext context)
        {
            _context = context;
        }
    
        public async Task<List<Order>> GetOrdersByUserIdAsync(string userId)
        {
           return await _context.Orders.Include(n => n.OrderItems).ThenInclude(n => n.Book)
                .Where(n => n.UserId == userId).ToListAsync();
        }

        public async Task StoreOrderAsync(List<ShopingCartItem> items, string userId, string userEmailAddress)
        {
            var order = new Order()
            {
                UserId = userId,
                Email = userEmailAddress
            };

            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            foreach (var item in items)
            {
                var orderItem = new OrderItem()
                {
                    Amount = item.Amount,
                    BookId = item.Book.Id,
                    OrderId = order.Id,
                    Price = item.Book.Price
                };
                await _context.OrderItems.AddAsync(orderItem);    
            }
            await _context.SaveChangesAsync();
        }
    }
}
