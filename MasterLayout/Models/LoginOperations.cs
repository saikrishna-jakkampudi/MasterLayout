using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterLayout.Models
{
    public class LoginOperations
    {
        static DemoEntities D = new DemoEntities();
        public static string login(string username, string password)
        {
            var LE = (from L in D.tbl_Login
                     where L.username == username && L.password == password
                     select L).FirstOrDefault();
         
                
            if (LE != null)
            {
                
                return "Welcome" + LE.username;
            }
            else
            {
                return null;
            }
        }
    }
}