using ELibraryStore.Data;
using ELibraryStore.Data.ViewModel;
using ELibraryStore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ELibraryStore.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signManager;
        private readonly ApplicationDbContext _context;
        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signManager, ApplicationDbContext context)
        {
            _userManager = userManager;
            _signManager = signManager;
            _context = context;
        }
        public IActionResult Login()
        {
            LoginVM respone = new LoginVM();
            return View(respone);
        }

    }
}
