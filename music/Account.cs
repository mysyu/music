using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace music
{
    public static class Account
    {
        public static bool islogin = false;
        public static string email = "";

        public static string Login(string e, string p)
        {
            DataTable result = DB.Select(String.Format("Select * from account where email={0}, password={1}", e, p));
            if ( result.Rows.Count == 1 )
            {
                islogin = true;
                email = e;
                return "Success";
            }
            else
            {
                return "Fail";
            }
        }
        public static void Logout()
        {
            islogin = false;
            email = "";
        }
        public static string regist(string e, string p)
        {
            int result = DB.SQL(String.Format("INSERT INTO account(email , password) VALUES ({0},{1})", e, p));
            if (result == 1)
                return "Regist Success";
            else
                return "Regist Fail";
        }
    }

}
