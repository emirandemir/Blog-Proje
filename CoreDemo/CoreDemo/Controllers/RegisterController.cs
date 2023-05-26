using BusinessLayer.Concrete;
using BusinessLayer.ValidationRule;
using CoreLayer.Fluent;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer)
        {
            ValidationTool.Validationtool(new WriterValidator(), writer);
            

            writer.WriterStatus = true;
            writer.WriterAbout = "Deneme";
            wm.Add(writer);
            return RedirectToAction("Index", "Blog");



        }
    }
}
