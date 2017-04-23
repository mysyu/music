using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;

namespace music
{
    public static class Account
    {
        public static bool islogin = false;
        public static string email = "";

        public static string Login(string e, string p)
        {
            if ( !validateEmail( e ) )
                return "無法辨識的email";
            if ( !validatePassword( p ) )
                return "密碼格式錯誤(須為A-Z,a-z,0-9)";
            DataTable result = DB.Select( String.Format( "Select * from account where email='{0}'" , e ) );
            if ( result.Rows.Count != 1 )
            {
                return "查無此email";
            }
            result = DB.Select( String.Format( "Select * from account where email='{0}' and password='{1}'" , e , p ) );
            if ( result.Rows.Count == 1 )
            {
                islogin = true;
                email = e;
                return "Success";
            }
            else
            {
                return "密碼錯誤";
            }
        }
        public static void Logout()
        {
            islogin = false;
            email = "";
        }
        public static string Register(string e, string p)
        {
            if ( !validateEmail( e ) )
                return "無法辨識的email";
            if ( !validatePassword( p ) )
                return "密碼格式錯誤(須為A-Z,a-z,0-9)";
            int result = DB.SQL(String.Format("INSERT INTO account(email , password) VALUES ('{0}','{1}')", e, p));
            if (result == 1)
                return "Success";
            else
                return "email已被註冊";
        }

        public static bool validateEmail( string e )
        {
            try
            {
                return Regex.IsMatch( e ,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$" ,
                      RegexOptions.IgnoreCase , TimeSpan.FromMilliseconds( 250 ) );
            }
            catch ( RegexMatchTimeoutException )
            {
                return false;
            }
        }

        public static bool validatePassword( string p )
        {
            try
            {
                return Regex.IsMatch( p ,
                      @"^[A-Za-z0-9]+$" ,
                      RegexOptions.IgnoreCase , TimeSpan.FromMilliseconds( 250 ) );
            }
            catch ( RegexMatchTimeoutException )
            {
                return false;
            }
        }
    }

}
