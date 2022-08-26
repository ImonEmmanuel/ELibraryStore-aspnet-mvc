using ELibraryStore.Data;
using ELibraryStore.Data.Services;
using ELibraryStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ELibraryStore.Controllers
{
    public class AuthorController : Controller
    {

        private readonly IAuthorService _service;
        public AuthorController(IAuthorService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();

            return View(data);
        }

        //Get:Author/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureUrl, FullName, Biography")] Author author)
        {
            if(author.ProfilePictureUrl != null && author.FullName != null && author.Biography != null)
            {
                await _service.AddAsync(author);
                return RedirectToAction(nameof(Index));
            }

            return View(author);
            //if (!ModelState.IsValid) Cant Figur
            //{
            //    return View(author);
            //}
            
        }

        //Get:Authors/Details/{id}
        public async Task<IActionResult> Details(int id)
        {
            var authorData = await _service.GetByIdAsync(id);
            if(authorData == null)
            {
                return View("NotFound");
            }
            return View(authorData);
        }

        //Get:Author/Update
        public async Task<IActionResult> Edit(int id)
        {
            var authorData = await _service.GetByIdAsync(id);
            if (authorData == null)
            {
                return View("NotFound");
            }
            return View(authorData);

        }

        [HttpPost]
        //[Bind("Id, FullName, ProfilePictureUrl, Biography")]
        public async Task<IActionResult> Edit(int id, Author author)
        {
            if (!ModelState.IsValid)
            {
                return View(author);
            }
            if (author.ProfilePictureUrl != null && author.FullName != null && author.Biography != null)
            {
                await _service.UpdateAsync(id, author);
                return RedirectToAction(nameof(Index));
            }
            
            return View(author);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var authorData = await _service.GetByIdAsync(id);
            if (authorData == null)
            {
                return View("NotFound");
            }
            return View(authorData);
        }


        //Delete: Author/Delete/{id}
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmation(int id)
        {
            var authorData = await _service.GetByIdAsync(id);
            if (authorData == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}