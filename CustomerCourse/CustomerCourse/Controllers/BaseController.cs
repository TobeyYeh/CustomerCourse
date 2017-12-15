using CustomerCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerCourse.Controllers
{
    public class BaseController : Controller
    {
        protected 客戶資料Repository CustDataRepo = RepositoryHelper.Get客戶資料Repository();
        protected 客戶聯絡人Repository CustContactRepo = RepositoryHelper.Get客戶聯絡人Repository();
        protected 客戶銀行資訊Repository CustBankRepo = RepositoryHelper.Get客戶銀行資訊Repository();
        // GET: Base
        protected override void HandleUnknownAction(string actionName)
        {
            this.Redirect("/").ExecuteResult(this.ControllerContext);
        }
    }
}