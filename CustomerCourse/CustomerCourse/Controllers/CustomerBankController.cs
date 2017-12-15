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

        public ActionResult Create()
        {
            var data = CustDataRepo.Get取得客戶資料明細();
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var item in data)
            {
                items.Add(new SelectListItem()
                {
                    Text = item.Id.ToString(),
                    Value = item.Id.ToString()

                });
            }
            TempData["ID"] = items;
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(客戶銀行資訊 data)
        {

            if (ModelState.IsValid)
            {
                data.客戶Id = data.客戶Id;
                data.IsDeleted = false;
                CustBankRepo.Add(data);
                return RedirectToAction("List");
            }
            //else
            //{
            //    var getData = CustDataRepo.Get取得客戶資料明細();
            //    List<SelectListItem> items = new List<SelectListItem>();
            //    foreach (var item in getData)
            //    {
            //        items.Add(new SelectListItem()
            //        {
            //            Text = item.Id.ToString(),
            //            Value = item.Id.ToString()

            //        });
            //    }

            //    TempData["ID"] = items;
            //}

            return View();
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
                CustBankRepo.UnitOfWork.Commit();
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

        public ActionResult List()
        {
            var getlCustDetail = CustDataRepo.Get取得客戶資料明細();
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var item in getlCustDetail)
            {
                items.Add(new SelectListItem()
                {
                    Text = item.Id.ToString(),
                    Value = item.Id.ToString()

                });
            }
            TempData["ID"] = items;

            var data = CustBankRepo.getCustBankList();
            ViewData.Model = data;
            ViewBag.PageTitle = "客戶銀行資訊";
            return View();
        }

        public ActionResult Details(int id)
        {
            var data = CustBankRepo.Find(id);
            return View(data);
        }
    }

}