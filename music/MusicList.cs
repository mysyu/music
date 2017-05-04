using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Xml;

namespace music
{
    public static class MusicList
    {
        public static List<Music> current = new List<Music>();
        public static List<Music> local = new List<Music>();
        public static List<Music> account = new List<Music>();

        public static void save()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root;
            XmlElement type;
            XmlElement musicname;
            root = doc.CreateElement( "musiclist" );
            type = doc.CreateElement( "current" );
            foreach ( Music m in MusicList.current )
            {
                musicname = doc.CreateElement( "music" );
                musicname.SetAttribute( "ID" , m.ID );
                type.AppendChild( musicname );
            }
            root.AppendChild( type );
            type = doc.CreateElement( "local" );
            foreach ( Music m in MusicList.local )
            {
                musicname = doc.CreateElement( "music" );
                musicname.SetAttribute( "ID" , m.ID );
                type.AppendChild( musicname );
            }
            root.AppendChild( type );
            doc.AppendChild( root );
            doc.Save( "music.xml" );
        }
        public static void load()
        {
            if ( Account.islogin )
            {
                DataTable result = DB.Select( String.Format( "select music from musiclist where email = '{0}'" , Account.user.email ) );
                foreach ( DataRow row in result.Rows )
                {
                    account.Add( new Music( row[ 0 ].ToString() ) );
                }
            }
            else if ( File.Exists( "music.xml" ) )
            {
                XmlDocument doc = new XmlDocument();
                doc.Load( "music.xml" );
                foreach ( XmlNode type in doc.ChildNodes[ 0 ].ChildNodes )
                {
                    List<Music> now = ( type.Name == "current" ? current : local );
                    foreach ( XmlNode musicname in type.ChildNodes )
                    {
                        now.Add( new Music( musicname.Attributes[ "ID" ].InnerText ) );
                    }
                }
            }
        }

        public static List<Music> search( String command )
        {
            DataTable result = DB.Select( command );
            List<Music> l = new List<Music>();
            foreach ( DataRow row in result.Rows )
            {
                l.Add( new Music( row[ 0 ].ToString() ) );
            }
            return l;
        }

        public static bool add( String t , Music m )
        {
            List<Music> now;
            switch ( t )
            {
                case "local":
                    now = local;
                    break;
                case "account":
                    now = account;
                    break;
                default:
                    return false;
            }
            if ( now.Contains( m ) )
                return false;
            now.Add( m );
            save();
            return true;
        }

        public static void add( Music m , bool p )
        {
            if ( !current.Contains( m ) )
            {
                if ( p )
                    current.Insert( 0 , m );
                else
                    current.Add( m );
            }
            else
            {
                if ( p )
                {
                    current.Remove( m );
                    current.Insert( 0 , m );
                }
            }
            save();
        }

    }
}
