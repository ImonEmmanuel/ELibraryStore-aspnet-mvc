using ELibraryStore.Data;
using ELibraryStore.Data.Services;
using ELibraryStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ELibraryStore.Controllers
{
    public class BookStoreController : Controller
    {
        private readonly IBookStoreService _service;
        public BookStoreController(IBookStoreService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //GET: BookStore/details/{id}
        public async Task<IActionResult> Details(int id)
        {
            var storeDetails = await _service.GetByIdAsync(id);
            if (storeDetails == null)
            {
                return View("NotFound");
            }
            return View(storeDetails);
        }

        //Get:BookStore/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name, Logo, Description")] BookStore bookStore)
        {
            if (bookStore.Logo != null && bookStore.Name != null && bookStore.Description != null)
            {
                await _service.AddAsync(bookStore);
                return RedirectToAction(nameof(Index));
            }

            return View(bookStore);
            //if (!ModelState.IsValid) Cant Figure
            //{
            //    return View(author);
            //}
        }

        //Get:BookStore/Update
        public async Task<IActionResult> Edit(int id)
        {
            var bookStoreData = await _service.GetByIdAsync(id);
            if (bookStoreData == null)
            {
                return View("NotFound");
            }
            return View(bookStoreData);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Name, Logo, Description")] BookStore bookStore)
        {
            if (id == bookStore.Id)
            {
                if (bookStore.Logo != null && bookStore.Name != null && bookStore.Description != null)
                {
                    await _service.UpdateAsync(id, bookStore);
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(bookStore);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var bookStoreData = await _service.GetByIdAsync(id);
            if (bookStoreData == null)
            {
                return View("NotFound");
            }
            return View(bookStoreData);
        }

        //Delete: BookStore/Delete/{id}
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmation(int id)
        {
            var bookStoreData = await _service.GetByIdAsync(id);
            if (bookStoreData == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
