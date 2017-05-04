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
        public static int pos = -1;
        public static bool status = false;
        public static String time = "";


        public static void save()
        {
            XmlDocument doc = new XmlDocument();
            XmlElement root;
            XmlElement type;
            XmlElement musicname;
            root = doc.CreateElement( "musiclist" );
            type = doc.CreateElement( "current" );
            type.SetAttribute( "pos" , pos.ToString() );
            type.SetAttribute( "time" , time );
            type.SetAttribute( "status" , status.ToString() );
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
                    List<Music> now;
                    if ( type.Name == "current" )
                    {
                        now = current;
                        pos = Int32.Parse( type.Attributes[ "pos" ].InnerText );
                        time = type.Attributes[ "time" ].InnerText;
                        status = Boolean.Parse( type.Attributes[ "status" ].InnerText );
                    }
                    else
                        now = local;
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
            if ( t == "local" )
            {
                if ( local.Any( x => x.ID == m.ID ) )
                    return false;
                local.Add( m );
                return true;
            }
            else if ( t == "account" )
            {
                if ( account.Any( x => x.ID == m.ID ) )
                    return false;
                account.Add( m );
                if ( DB.SQL( String.Format( "insert into musiclist( email , music ) values( '{0}' , '{1}' )" , Account.user.email , m.ID ) ) == 1 )
                    return true;
            }
            return false;
        }

        public static void add( Music m , bool p )
        {
            if ( !current.Any( x => x.ID == m.ID ) )
            {
                if ( p )
                    current.Insert( pos , m );
                else
                    current.Add( m );
            }
            else
            {
                if ( p )
                {
                    pos = current.FindIndex( x => x.ID == m.ID );
                }
            }
        }
    }
}
