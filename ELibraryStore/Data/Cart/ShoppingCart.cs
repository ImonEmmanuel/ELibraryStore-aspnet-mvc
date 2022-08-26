using ELibraryStore.Models;
using Microsoft.EntityFrameworkCore;

namespace ELibraryStore.Data.Cart
{
    public class ShoppingCart
    {
        public ApplicationDbContext _context { get; set; }
        public string ShopingCartId { get; set; } 
        public List<ShopingCartItem> ShopingCartItems { get; set; }
        public ShoppingCart(ApplicationDbContext context)
        {
            _context = context; 
        }

        public static ShoppingCart GetShoppingCart(IServiceProvider services)
        {
            var session = services.GetRequiredService<IHttpContextAccessor>()? .HttpContext.Session;
            var context = services.GetService<ApplicationDbContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context)
            {
                ShopingCartId = cartId
            };
        }
        public List<ShopingCartItem> GetShopingCartItems()
        {
            return ShopingCartItems ?? (ShopingCartItems = _context.ShopingCartItems.
                Where(n => n.ShoppingCartId ==ShopingCartId)
                .Include(n => n.Book).ToList());
        }
        private double PriceNew(double price)
        {
            Conversion conversion = new Conversion();
            var newPrice = conversion.CurrencyConversion(price).Replace('N', ' ');
            return Convert.ToDouble(newPrice);
        }

        public double GetShoppingCartTotal()
        {
            var total = _context.ShopingCartItems.Where(n => n.ShoppingCartId == ShopingCartId)
                .Select(n => n.Amount * n.Book.Price).Sum();
            return total;
        }

        public void AddItemToCart(Book book)
        {
            var cartItem = _context.ShopingCartItems.FirstOrDefault
                (n => n.Book.Id == book.Id && n.ShoppingCartId == ShopingCartId);
            if(cartItem == null)
            {
                cartItem = new ShopingCartItem()
                {
                    ShoppingCartId = ShopingCartId,
                    Book = book,
                    Amount = 1
                };
                _context.ShopingCartItems.Add(cartItem); 
            }
            else
            {
                cartItem.Amount++;    
            }
            _context.SaveChanges(); 
        }

        public void RemoveItemFromCart(Book book)
        {
            var resultData = _context.ShopingCartItems.FirstOrDefault
                (n => n.Book.Id == book.Id && n.ShoppingCartId == ShopingCartId);

            if(resultData != null)
            {
                if (resultData.Amount > 1)
                {
                    resultData.Amount--;
                }
                else
                {
                    _context.ShopingCartItems.Remove(resultData);
                }
            }            
            _context.SaveChanges();
        }

        public async Task ClearShoppingCartAsync()
        {
            var items = await _context.ShopingCartItems.Where(n => n.ShoppingCartId == ShopingCartId).ToListAsync();

            _context.ShopingCartItems.RemoveRange(items);
            await _context.SaveChangesAsync();
        }
    }
}
