using MySql.Data.MySqlClient;
using System;
using System.Data;
using log4net;

namespace music.DB_Control
{
    public static class DB
    {
        private static String DBHost = "mysyu.ddns.net";
        private static String DBUser = "music";
        private static String DBPassword = "music";
        private static String DBName = "music";
        private static String DBCharSet = "utf8";
        private static MySqlConnection DBConnection = null;
        public static ILog Log = LogManager.GetLogger( "" );

        static DB()
        {
            try
            {
                if ( DBConnection == null )
                {
                    DBConnection = new MySqlConnection( String.Format( "server={0};uid={1};pwd={2};database={3};charset={4}" , DBHost , DBUser , DBPassword , DBName , DBCharSet ) );
                    DBConnection.Open();
                }
                Log.Debug( String.Format( "server={0};uid={1};pwd={2};database={3};charset={4}" , DBHost , DBUser , DBPassword , DBName , DBCharSet ) );
            }
            catch ( Exception e )
            {
                Log.Error( e.StackTrace );
            }
        }

        public static DataTable Select( String command )
        {
            DataTable result = new DataTable();
            try
            {
                result.Load( new MySqlCommand( command , DBConnection ).ExecuteReader() );
            }
            catch ( Exception e )
            {
                Log.Error( e.StackTrace );
            }
            return result;
        }

        public static int SQL( String command )
        {
            int result = -1;
            try
            {
                result = new MySqlCommand( command , DBConnection ).ExecuteNonQuery();
            }
            catch ( Exception e )
            {
                Log.Error( e.StackTrace );
            }
            return result;
        }

        public static void Close()
        {
            try
            {
                if ( DBConnection != null )
                {
                    DBConnection.Close();
                }
            }
            catch ( Exception e )
            {
                Log.Error( e.StackTrace );
            }
        }
    }
}
