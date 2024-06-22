using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApp.DAL.Interface;
using ShopApp.DAL.Models;
using ShopApp.Web.Models;
using System;

namespace ShopApp.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryDb categoryDb;

        public CategoryController(ICategoryDb CategoryDb)
        {
            this.categoryDb = CategoryDb;
        }

        public IActionResult Index()
        {
            var categories = categoryDb.GetCategories();
            return View(categories); 
        }

        public IActionResult Details(int id)
        {
            var category = categoryDb.GetCategoryDb(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryAddModel addModel)
        {
            try
            {
                addModel.Creation_Date = DateTime.Now;
                addModel.Creation_User = 1;
                this.categoryDb.SaveCategory(addModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var category = categoryDb.GetCategoryDb(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CategoryUpdateModel updateModel)
        {
            try
            {
                updateModel.Modify_Date = DateTime.Now;
                updateModel.Modify_User = 1;
                this.categoryDb.UpdateCategory(updateModel);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
