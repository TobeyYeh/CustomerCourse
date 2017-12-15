using CustomerCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerCourse.Controllers
{
    public class CustomerBankController : BaseController
    {
        // GET: CustomerBank
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(客戶銀行資訊 data)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }

            return View(data);
        }

        public ActionResult Edit()
        {

            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(int id, 客戶銀行資訊 data)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }

            return View(data);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Deleted(int id, 客戶銀行資訊 data)
        {
            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }

            return View(data);
        }

        public ActionResult Details()
        {
            var data = CustBankRepo.getCustBankList();
            ViewData.Model = data;
            ViewBag.PageTitle = "客戶銀行清單";
            return View();
        }
    }
}