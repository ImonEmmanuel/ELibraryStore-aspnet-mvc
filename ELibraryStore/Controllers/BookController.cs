using ELibraryStore.Data;
using ELibraryStore.Data.Services;
using ELibraryStore.Data.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace ELibraryStore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _services;

        public BookController(IBookService service)
        {
            _services = service;
        }
    
        public async Task<IActionResult> Index()
        {
            var data = await _services.GetAllAsync(x => x.BookStore);
            return View(data);
        }

        public async Task<IActionResult> Filter(string searchParameter)
        {
            var data = await _services.GetAllAsync(x => x.BookStore);

            if(!string.IsNullOrEmpty(searchParameter))
            {
                var filterdValue = data.Where(n => n.Name.Contains(searchParameter) || n.Description.Contains(searchParameter)
                ||n.BookCategory.ToString().Contains(searchParameter)).OrderBy(x => x.Name).ToList();

                return View("Index", filterdValue);
            }
            return View("Index", data);
        }

        //Get Book/Details/{id}
        public async Task<IActionResult> Details(int id)
        {
            var bookData = await _services.GetBookbyIdAsync(id); 
            if(bookData == null)
            {
                return View("NotFound");
            }
            return View(bookData);
        }

        //Get: Book/Create
        public async Task<IActionResult> Create()
        {
            var bookDropData = await _services.GetNewBookDropDownValue();

            ViewBag.BookStores = new SelectList(bookDropData.BookStores, "Id", "Name");
            ViewBag.Publishers = new SelectList(bookDropData.Publishers, "Id", "FullName");
            ViewBag.Authors = new SelectList(bookDropData.Authors, "Id", "FullName");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewBookVM bookVM)
        {
            if(!ModelState.IsValid)
            {
                //Remove this before deployment
                var errors = ModelState.Values.Where(E => E.Errors.Count > 0)
                         .SelectMany(E => E.Errors)
                         .Select(E => E.ErrorMessage)
                         .ToList();

                var bookDropData = await _services.GetNewBookDropDownValue();
                ViewBag.BookStores = new SelectList(bookDropData.BookStores, "Id", "Name");
                ViewBag.Publishers = new SelectList(bookDropData.Publishers, "Id", "FullName");
                ViewBag.Authors = new SelectList(bookDropData.Authors, "Id", "FullName");

                return View(bookVM);
            }
            await _services.AddNewBookAsync(bookVM);
            return RedirectToAction(nameof(Index));
        }

        //Get: Book/Update
        public async Task<IActionResult> Edit(int id)
        {
            var bookDetails = await _services.GetBookbyIdAsync(id);
            if (bookDetails == null)
            {
                return View("NotFound");
            }

            var response = new NewBookVM()
            {
                Id = bookDetails.Id,
                Name = bookDetails.Name,
                Description = bookDetails.Description,
                Price = bookDetails.Price,
                DateAdded = bookDetails.DateAdded,
                ImageUrl = bookDetails.ImageUrl,
                BookUrl = bookDetails.BookUrl,
                BookCategory = bookDetails.BookCategory,
                PublisherId = (int)bookDetails.PublisherId,
                BookEdition = bookDetails.BookEdition,
                BookStoreId = (int)bookDetails.BookStoreId,
                AuthorId = bookDetails.Book_Authors.Select(n => n.AuthorId).ToList()

            };
            var bookDropData = await _services.GetNewBookDropDownValue();

            ViewBag.BookStores = new SelectList(bookDropData.BookStores, "Id", "Name");
            ViewBag.Publishers = new SelectList(bookDropData.Publishers, "Id", "FullName");
            ViewBag.Authors = new SelectList(bookDropData.Authors, "Id", "FullName");
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewBookVM bookVM)
        {
            if (id != bookVM.Id)
            {
                return View("NotFound");
            }
            if (!ModelState.IsValid)
            {
                //Remove this before deployment
                var errors = ModelState.Values.Where(E => E.Errors.Count > 0)
                         .SelectMany(E => E.Errors)
                         .Select(E => E.ErrorMessage)
                         .ToList();

                var bookDropData = await _services.GetNewBookDropDownValue();
                ViewBag.BookStores = new SelectList(bookDropData.BookStores, "Id", "Name");
                ViewBag.Publishers = new SelectList(bookDropData.Publishers, "Id", "FullName");
                ViewBag.Authors = new SelectList(bookDropData.Authors, "Id", "FullName");

                return View(bookVM);
            }
            await _services.UpdateBookAsync(bookVM);
            return RedirectToAction(nameof(Index));
        }
    }
}
