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

            //var dataTotal = CustBankRepo.getCustBankList();

            //List<SelectListItem> items = new List<SelectListItem>();

            //foreach (var item in dataTotal)
            //{
            //    items.Add(new SelectListItem { Text = item.客戶Id.ToString(), Value = item.客戶Id.ToString() });
            //}

            //ViewBag.getItem = items;
            return View();
        }

        public ActionResult Create()
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
        public ActionResult Delete(int id, 客戶銀行資訊 data)
        {
            if (ModelState.IsValid)
            {
                var item = CustBankRepo.Find(id);
                CustBankRepo.Delete(item);
                return RedirectToAction("Details");
            }

            return View(data);
        }

        public ActionResult Details()
        {
            var data = CustBankRepo.getCustBankList();
            ViewData.Model = data;
            ViewBag.PageTitle = "客戶銀行資訊";
            return View();
        }
    }
}