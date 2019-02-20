using Autofac;
using Autofac.Integration.Mvc;
using IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.App_Start;

namespace WebApplication1.Controllers
{
    /// <summary>
    /// Install-Package AutoFac.MVC5
    /// </summary>
    public class DefaultController : Controller
    {
        public IUserService userService { get; set; }

        // GET: Default
        public ActionResult Index()
        {

            Person p = new Person();

            return Json(p,JsonRequestBehavior.AllowGet);
        }
    }

    public class Person
    {
        public DateTime Sj { get; set; } =  DateTime.Now;
    }
}