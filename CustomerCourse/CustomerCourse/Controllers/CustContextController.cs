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

            var data = CustContactRepo.get客戶聯絡人清單();
            ViewData.Model = data;
            ViewBag.PageTitle = "客戶聯絡人清單";
            return View();
        }

        public ActionResult Create()
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
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(客戶聯絡人 data)
        {
            if (ModelState.IsValid)
            {
                data.客戶Id = data.Id;
                data.IsDeleted = false;
                CustContactRepo.Add(data);
                return RedirectToAction("Index");
            }
            else
            {
                var getData = CustDataRepo.Get取得客戶資料明細();
                List<SelectListItem> items = new List<SelectListItem>();
                foreach (var item in getData)
                {
                    items.Add(new SelectListItem()
                    {
                        Text = item.Id.ToString(),
                        Value = item.Id.ToString()

                    });
                }

                TempData["ID"] = items;
            }

            return View();
        }


        public ActionResult Details(int id)
        {
            var getData = CustDataRepo.Get取得客戶資料明細();
            List<SelectListItem> items = new List<SelectListItem>();
            foreach (var item in getData)
            {
                items.Add(new SelectListItem()
                {
                    Text = item.Id.ToString(),
                    Value = item.Id.ToString()

                });
            }

            TempData["ID"] = items;

            var data = CustContactRepo.Find(id);
            return View(data);
        }

        public ActionResult Edit(int id)
        {

            var item = CustContactRepo.Find(id);


            return View(item);

        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Edit(int id, 客戶聯絡人 data)
        {
            if (ModelState.IsValid)
            {
                var item = CustContactRepo.Find(id);
                item.姓名 = data.姓名;
                item.客戶資料 = data.客戶資料;
                item.手機 = data.手機;
                item.職稱 = data.職稱;
                item.電話 = data.電話;
                CustBankRepo.UnitOfWork.Commit();
                return RedirectToAction("Index");
            }

            return View(data);
        }


    }
}