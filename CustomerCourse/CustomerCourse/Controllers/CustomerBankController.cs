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
                CustBankRepo.Add(data);
                return RedirectToAction("Index");
            }

            return View(data);
        }

        public ActionResult Edit(int id)
        {
            var item = CustBankRepo.Find(id);
          
           
            return View(item);
          
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(int id, 客戶銀行資訊 data)
        {
            if (ModelState.IsValid)
            {
                var item = CustBankRepo.Find(id);
                item.分行代碼 = data.分行代碼;
                item.客戶資料 = data.客戶資料;
                item.帳戶號碼 = data.帳戶號碼;
                item.銀行代碼 = data.銀行代碼;
                item.銀行名稱 = data.銀行名稱;
                CustBankRepo.Update(data);
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