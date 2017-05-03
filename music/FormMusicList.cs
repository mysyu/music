using System;
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
    public partial class FormMusicList : Form
    {
        public FormMusicList()
        {
            InitializeComponent();
        }

        public void Set( List<Music> musiclist )
        {
            dataGridView1.Rows.Clear();
            if ( musiclist == null )
                return;
            foreach ( Music m in musiclist )
            {
                dataGridView1.Rows.Add( 1 );
                dataGridView1.Rows[ 0 ].Cells[ 0 ].Value = m;
                dataGridView1.Rows[ 0 ].Cells[ 1 ].Value = ( (Music) dataGridView1.Rows[ 0 ].Cells[ 0 ].Value ).singer;
                dataGridView1.Rows[ 0 ].Cells[ 2 ].Value = "hi";
            }
        }

        private void dataGridView1_CellContentClick( object sender , DataGridViewCellEventArgs e )
        {
            switch ( e.ColumnIndex )
            {
                case 2:
                    FormMusicInfo formMusicInfo = new FormMusicInfo();
                    formMusicInfo.TopLevel = false;
                    formMusicInfo.Dock = DockStyle.Fill;
                    formMusicInfo.FormBorderStyle = FormBorderStyle.None;
                    FormMain.main.mainPanel.Controls.Add( formMusicInfo );
                    formMusicInfo.BringToFront();
                    formMusicInfo.Set( (Music) dataGridView1.Rows[ e.RowIndex ].Cells[ 0 ].Value );
                    formMusicInfo.Show();
                    break;
                case 3:
                    FormMusicSinger formMusicSinger = new FormMusicSinger();
                    formMusicSinger.TopLevel = false;
                    formMusicSinger.Dock = DockStyle.Fill;
                    formMusicSinger.FormBorderStyle = FormBorderStyle.None;
                    FormMain.main.mainPanel.Controls.Add( formMusicSinger );
                    formMusicSinger.BringToFront();
                    formMusicSinger.Set( new Account( (Music) dataGridView1.Rows[ e.RowIndex ].Cells[ 0 ].Value ) );
                    formMusicSinger.Show();
                    break;
                case 4:
                    break;
                case 5:
                    FormMain.main.musicPlayer.URL = String.Format( "http://mysyu.ddns.net/UploadMusic/{0}{1}" , ( ( Music ) dataGridView1.Rows[ e.RowIndex ].Cells[ 0 ].Value ).ID , ( (Music) dataGridView1.Rows[ e.RowIndex ].Cells[ 0 ].Value ).extension );
                    MusicList.add( (Music) dataGridView1.Rows[ e.RowIndex ].Cells[ 0 ].Value , true );
                    break;

            }
        }

        private void CheckedChanged( object sender , EventArgs e ) 
        {
            String command = "Select ID from uploadmusic where 1 = 0";
            foreach ( CheckBox c in tag.Controls.OfType<CheckBox>().Where( r => r.Checked ) )
                command += String.Format( " or tag like '%{0}%'" , c.Text );
            Set( MusicList.search( command ) );
        }
    }
}
