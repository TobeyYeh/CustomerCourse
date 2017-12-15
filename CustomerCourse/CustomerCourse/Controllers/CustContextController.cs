using CustomerCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerCourse.Controllers
{
    public class CustContextController : BaseController
    {
        // GET: CustContext
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details()
        {
            var data = CustContactRepo.get客戶聯絡人清單();
            ViewData.Model = data;
            ViewBag.PageTitle = "客戶聯絡人清單";
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(客戶聯絡人 data)
        {
            if (ModelState.IsValid)
            {
                CustContactRepo.Add(data);
                return RedirectToAction("Index");
            }

            return View(data);
        }


    }
}