using ELibraryStore.Data;
using ELibraryStore.Data.Services;
using ELibraryStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace ELibraryStore.Controllers
{
    public class PublisherController : Controller
    {
        private readonly IPublisherService _service;
        public PublisherController(IPublisherService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //GET: Publisher/details/{id}
        public async Task<IActionResult> Details(int id)
        {
            var publisherDetails = await _service.GetByIdAsync(id);
            if (publisherDetails == null)
            {
                return View("NotFound");
            }
            return View(publisherDetails);
        }

        //Get:Publisher/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("ProfilePictureUrl, FullName, Description")] Publisher publisher)
        {
            if (publisher.ProfilePictureUrl != null && publisher.FullName != null && publisher.Description != null)
            {
                await _service.AddAsync(publisher);
                return RedirectToAction(nameof(Index));
            }

            return View(publisher);
        }

        //Get:Publisher/Update
        public async Task<IActionResult> Edit(int id)
        {
            var publisherData = await _service.GetByIdAsync(id);
            if (publisherData == null)
            {
                return View("NotFound");
            }
            return View(publisherData);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, FullName, ProfilePictureUrl, Description")] Publisher publisher)
        {
            if(id == publisher.Id)
            {
                if(publisher.ProfilePictureUrl != null && publisher.FullName != null && publisher.Description != null)
                {
                    await _service.UpdateAsync(id, publisher);
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(publisher);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var publisherData = await _service.GetByIdAsync(id);
            if (publisherData == null)
            {
                return View("NotFound");
            }
            return View(publisherData);
        }

        //Delete: Publisher/Delete/{id}
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmation(int id)
        {
            var publisherData = await _service.GetByIdAsync(id);
            if (publisherData == null)
            {
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

//if (!ModelState.IsValid)
//{
//    var error = ModelState.Select(x => x.Value.Errors).Where(y => y.Count > 0).ToList();
//    return View(publisher);
//}
//await _service.AddAsync(publisher);
//return RedirectToAction(nameof(Index));
