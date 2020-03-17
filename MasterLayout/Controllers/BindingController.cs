using MasterLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterLayout.Controllers
{
    public class BindingController : Controller
    {
        // GET: Binding
        [ActionName("Example")]
        public ActionResult Sample()
        {
            return View("Sample");
        }
        public ActionResult Index()
        {
            return View() ;
        }
        // Primitive Data Binding
        public ActionResult Update(int id)
        {
            return View("Index",EmpOperations.GetEmp(id));
        }

        // Complex Databinding
        //////[HttpPost]
        //////public ActionResult Update(EMPDATA E)
        //////{
        //////    return View();
        //////}

       // Basic Type Binding
       //[HttpPost]
       // public ActionResult Update(int EMPNO, string ENAME, string JOB, int MGR, DateTime HIREDATE, int SAL, int COMM, int DEPTNO)
       // {
       //     return View();
       // }

        //Form Collection Binding

        //[HttpPost]
        //public ActionResult Update(FormCollection FC)
        //{
        //    int eno = int.Parse(FC["EMPNO"]);
        //    string Ename = FC["ENAME"];
        //    return View();
        //}

        [HttpPost]
        public ActionResult Update([Bind(Include="ENAME,JOB")] EMPDATA E)
  // Include binds only the selected values where as excludes binds other then the selected values.
        {
            return View();
        }
    }


}