using CustomerCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerCourse.Controllers
{
    public class CustomerDataController : BaseController
    {
        CustomerEntities db = new CustomerEntities();
        // GET: CustomerData
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(客戶資料 data)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(data);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(int id, 客戶資料 data)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }

            return View(data);
        }

    }
}