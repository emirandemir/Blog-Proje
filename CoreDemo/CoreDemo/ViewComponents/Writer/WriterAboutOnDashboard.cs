﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IViewComponentResult Invoke()
        {
            var writer = wm.GetWriterById(1); 
            return View(writer);
        }
    }
}
