using System;
using System.Web.Mvc;

namespace E5R.AspNet.WebApi.Owin.Controllers
{
    public class MoreController : Controller
    {
        public ActionResult Index(Nullable<int> id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}