using MasterLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterLayout.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult Index()
        {
            List<EMPDATA> L = EmpOperations.GetAll();
            return View(L);
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit(int? id)
        {
            return View();
        }
    }
}