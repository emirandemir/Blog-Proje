using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class CategoryController : Controller
    {
       
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult Index(int page=1)
        {
            var values = cm.GetList().ToPagedList(page,3);
            return View(values);
        }

        [HttpGet]
        public IActionResult CategoryAdd()
        {
            return View();
        }

        public IActionResult CategoryAdd(Category category)
        {
            category.CategoryStatus = true;
            cm.Add(category);
            return RedirectToAction("Index","Category");
        }

        public IActionResult CategoryDelete(int id)
        {
            var deletevalues = cm.GetList().Where(x => x.CategoryID == id).FirstOrDefault();
            cm.Delete(deletevalues);
            return RedirectToAction("Index");
        }
    }
}
