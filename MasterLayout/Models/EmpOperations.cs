using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MasterLayout.Models
{
    public class EmpOperations
    {
        static DemoEntities D = new DemoEntities();

        public static string InsertEmp(EMPDATA E)
        {
            try
            {
                D.EMPDATAs.Add(E);
                D.SaveChanges();
            }

            catch (DbUpdateException Ey)
            {
                SqlException Ex = Ey.GetBaseException() as SqlException;
                if (Ex.Message.Contains("FK_EmpDept"))
                {
                    return "No Proper Deptno";
                }
                else if (Ex.Message.Contains("PK_EMP"))
                {
                    return "Empno Cannot be empty";

                }
                else
                {
                    return "Error Occured";
                }

            }

            return "Done";
        }
        public static EMPDATA GetEmp(int Empno)
        {
            EMPDATA LE= (from L in D.EMPDATAs
                     where L.EMPNO == Empno
                     select L).FirstOrDefault();
            return LE;
        }
        public static List<EMPDATA> GetAll()
        {
            var E = from E1 in D.EMPDATAs
                    select E1;
            return E.ToList();
        }
        public static string empdelete(int Empno)
        {
            var emp = (from E in D.EMPDATAs
                       where E.EMPNO == Empno
                       select E).FirstOrDefault();
            D.EMPDATAs.Remove(emp);
            D.SaveChanges();
            return "1 Row Deleted";
        }


    }
}