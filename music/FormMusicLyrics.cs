﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace music
{
    public partial class FormMusicLyrics : Form
    {
        public Music music = null;

        public FormMusicLyrics()
        {
            InitializeComponent();
            checkLyrics.Start();
        }

        public void Set( Music m )
        {
            music = m;
            name.Text = music.name;
            singer.Text = music.singer;
            lyrics.Items.Clear();
            lyrics.Items.AddRange( music.lyrics.lyrics );
        }

        private void lyrics_MouseDown( object sender , MouseEventArgs e )
        {
            String t = music.lyrics.getTime( lyrics.IndexFromPoint( e.Location ) , FormMain.main.musicPlayer.currentMedia.durationString );
            if ( t != "" )
                FormMain.main.musicPlayer.Ctlcontrols.currentPosition = Int32.Parse( t.Substring( 0 , 2 ) ) * 60 + Int32.Parse( t.Substring( 3 , 2 ) );
        }

        private void checkLyrics_Tick( object sender , EventArgs e )
        {
            if ( MusicList.current[ MusicList.pos ] != music )
                Set( MusicList.current[ MusicList.pos ] );
            lyrics.SelectedIndex = music.lyrics.getLine( FormMain.main.musicPlayer.Ctlcontrols.currentPositionString );

        }
    }
}
