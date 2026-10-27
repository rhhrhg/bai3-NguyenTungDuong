using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bai3.Models
{
    public class CategoryController : Controller
    {
        //gia lap csdl
        public static List<Models.Category> categories = new List<Models.Category>()
        {
            new Models.Category(){Id=1, Name="Laptop"},
            new Models.Category(){Id=2, Name="Phone"},
            new Models.Category(){Id=3, Name="Tablet"},
        };

        // GET: CategoryController
        public ActionResult Index()
        {
            return View(categories);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
                return NotFound();
            return View(category);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        public ActionResult Create(Models.Category category)
        {
            categories.Add(category);
            return RedirectToAction(nameof(Index));
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
                return NotFound();
            return View(category);
        }

        // POST: CategoryController/Edit
        [HttpPost]
        public ActionResult Edit(Models.Category category)
        {
            var existing = categories.FirstOrDefault(c => c.Id == category.Id);
            if (existing != null)
            {
                existing.Name = category.Name;
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
                return NotFound();
            return View(category);
        }

        // POST: CategoryController/Delete
        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
                categories.Remove(category);
            return RedirectToAction(nameof(Index));
        }

    }
}