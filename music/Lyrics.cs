using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Globalization;
using System.Windows;
using System.Text.RegularExpressions;

namespace music
{
    public class Lyrics
    {
        public String completeLyrics;
        public String[] lyrics;

        public Lyrics( String l )
        {
            completeLyrics = l;
            lyrics = l.Replace( "\r" , "" ).Split( '\n' );
        }

        public String getTime( int n , String t )
        {
            if ( Regex.IsMatch( lyrics[ n ] , @"[\d\d:\d\d]" ) && lyrics[ n ].Substring( 1 , 5 ).CompareTo( t ) <= 0 )
                return lyrics[ n ].Substring( 1 , 5 );
            else
                return "";
        }

        public int getLine( String t )
        {
            int now = 0;
            while ( Regex.IsMatch( lyrics[ now + 1 ] , @"[\d\d:\d\d]" ) && lyrics[ now + 1 ].Substring( 1 , 5 ).CompareTo( t ) <= 0 )
                now++;
            return now;
        }
    }
}
