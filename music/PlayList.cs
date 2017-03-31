using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace music
{
    public static class PlayList
    {
        public static Dictionary<String , List<Music>> local = new Dictionary<string, List<Music>>();
        public static Dictionary<String , List<Music>> account = new Dictionary<string , List<Music>>();
        public static Dictionary<String , List<Music>> current = new Dictionary<string , List<Music>>();
        static PlayList()
        {
            if ( !File.Exists( "music.xml" ) )
            {
                File.Create( "music.xml" );
            }
        }
    }
}
