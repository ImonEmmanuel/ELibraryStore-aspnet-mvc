using ELibraryStore.Data.Cart;
using Microsoft.AspNetCore.Mvc;

namespace ELibraryStore.Data.ViewComponents
{
    public class ShopingCartSummaryVC : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public ShopingCartSummaryVC(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = _shoppingCart.GetShopingCartItems();
            return View(items.Count);
        }
    }
}