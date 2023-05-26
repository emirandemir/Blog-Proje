using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class NatificationController : Controller
    {
        NatificationManager nm = new NatificationManager(new EfNatificationRepository());
        public IActionResult Index()
        {

            return View();
        }

        public IActionResult AllNotification()
        {
           var values = nm.GetList();
            return View(values);
        }
    }
}
