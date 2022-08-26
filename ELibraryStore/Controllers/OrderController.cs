using ELibraryStore.Data.Cart;
using ELibraryStore.Data.Services;
using ELibraryStore.Data.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace ELibraryStore.Controllers
{
    public class OrderController : Controller
    {
        private readonly IBookService _bookService;
        private readonly ShoppingCart _shopingCart;
        private readonly IOrderService _orderService;
        private readonly IPaymentService _paymentService;
        public OrderController(IBookService bookService, ShoppingCart shoppingCart, IOrderService orderService, IPaymentService paymentService)
        {
            _bookService = bookService;
            _shopingCart = shoppingCart;
            _orderService = orderService;
            _paymentService = paymentService;
        }

        public async Task<IActionResult> Index()
        {
            string userId = "";
            var orders = await _orderService.GetOrdersByUserIdAsync(userId);
            return View(orders);    
        }
        public IActionResult ShoppingCart()
        {
            var items = _shopingCart.GetShopingCartItems();
            _shopingCart.ShopingCartItems = items;
            var response = new ShoppingCartVM()
            {
                ShoppingCart = _shopingCart,
                ShoppingCartTotal = _shopingCart.GetShoppingCartTotal()
            };

            return View(response);
        }

        public async Task<RedirectToActionResult> AddToShoppingCart(int id)
        {
            var item = await _bookService.GetBookbyIdAsync(id);
            if (item != null)
            {
                _shopingCart.AddItemToCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<RedirectToActionResult> RemoveFromShoppingCart(int id)
        {
            var item = await _bookService.GetByIdAsync(id);
            if(item != null)
            {
                _shopingCart.RemoveItemFromCart(item);
            }
            return RedirectToAction(nameof(ShoppingCart));
        }

        public async Task<IActionResult> CompleteOrder()
        {
            //var item = _shopingCart.GetShopingCartItems();
            var totalAmount = _shopingCart.GetShoppingCartTotal();

            var data = await _paymentService.InitializeTransaction(totalAmount);
            if (data.authorization_url!= null)
            {
                return Redirect(data.authorization_url.ToString());
            }
            return RedirectToAction(nameof(ShoppingCart));

            //return View("OrderCOmpleted");
        }

        [HttpGet]
        public async Task<IActionResult> VerifyPaymentOrder(string reference)
        {
            var item = _shopingCart.GetShopingCartItems();
            string response = await _paymentService.VerifyTransaction(reference);
            if(response != null)
            {
                if (response == "true")
                {
                    string userId = "";
                    string userEmailAddress = "";
                    await _orderService.StoreOrderAsync(item, userId, userEmailAddress);
                    await _shopingCart.ClearShoppingCartAsync();
                    return View("OrderCOmpleted");
                }
                ViewData["error"] = response;
                return View();
            }
            ViewData["error"] = response;
            return View();
        }


    }
}
