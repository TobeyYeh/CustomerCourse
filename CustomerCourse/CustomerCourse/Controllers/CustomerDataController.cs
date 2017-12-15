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
                CustDataRepo.Add(data);
                return RedirectToAction("Index");
            }


            return View(data);
        }

        public ActionResult Edit(int id)
        {
            //找到id
            var item = CustDataRepo.Find(id);
            return View(item);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(int id, 客戶資料 data)
        {
            if (ModelState.IsValid)
            {
                //automap 之後整理用
                var item = CustDataRepo.Find(id);
                item.傳真 = data.傳真;
                item.Email = data.Email;
                item.地址 = data.地址;
                item.客戶分類 = data.客戶分類;
                item.客戶聯絡人 = data.客戶聯絡人;
                item.客戶銀行資訊 = data.客戶銀行資訊;
                item.統一編號 = data.統一編號;
                item.電話 = data.電話;

                CustDataRepo.Update(data);
                return RedirectToAction("Index");
            }

            return View(data);
        }

        public ActionResult Details()
        {
            var data = CustDataRepo.Get取得客戶資料明細();
            ViewData.Model = data;
            return View();

        }

        public ActionResult Delete(int id)
        {
            var item = CustDataRepo.Find(id);
            CustDataRepo.Delete(item);
            return RedirectToAction("Details");
        }

    }
}