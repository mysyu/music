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
    public partial class FormHome : Form
    {
        private List<Panel> panels = null;
        private List<String> tags = null;
        private Music select = null;

        public FormHome()
        {
            InitializeComponent();
        }
        private void tag_Click( object sender , EventArgs e )
        {
            FormMusicList formMusicList = new FormMusicList();
            formMusicList.TopLevel = false;
            formMusicList.Dock = DockStyle.Fill;
            formMusicList.FormBorderStyle = FormBorderStyle.None;
            FormMain.main.mainPanel.Controls.Add( formMusicList );
            formMusicList.BringToFront();
            formMusicList.Show();
        }

        private void FormHome_Shown( object sender , EventArgs e )
        {
            table.Top = tag.Bottom;
            tags = new List<string>();
            tags.Add( "所有類型" );
            tags.Add( "原創" );
            tags.Add( "翻唱" );
            tags.Add( "純音樂" );
            tags.Add( "重金屬" );
            tags.Add( "搖滾" );
            tags.Add( "爵士" );
            tags.Add( "輕音樂" );
            tags.Add( "流行音樂" );
            table.Controls.Clear();
            table.RowCount = (int) Math.Ceiling( tags.Count / 4.0 );
            panels = new List<Panel>();
            for ( int i = 0 ; i < table.RowCount ; i++ )
            {
                table.RowStyles.Add( new System.Windows.Forms.RowStyle( System.Windows.Forms.SizeType.Absolute , 250F ) );
                for ( int j = 0 ; j < table.ColumnCount ; j++ )
                {
                    Panel panel = new Panel();
                    panel.Dock = DockStyle.Fill;
                    panels.Add( panel );
                    table.Controls.Add( panel , j , i );
                }
            }
            Set();
        }

        private void Set()
        {
            for ( int i = 0 ; i < tags.Count ; i++ )
            {
                int top = 5;
                panels[ i ].Controls.Clear();
                Label label = new Label();
                label.Text = tags[ i ] + " Top 5";
                label.Location = new Point( 5 , top );
                panels[ i ].Controls.Add( label );
                LinkLabel link = null;
                foreach( Music m in MusicList.search( String.Format( "Select ID from uploadmusic where 1 = 0 or tag like '%{0}%' order by listen desc" , tags[ i ] == "所有類型" ? "" : tags[ i ] ) ) )
                {
                    top += 30;
                    link = new LinkLabel();
                    link.Text = m.name;
                    link.Tag = (Object) m;
                    link.LinkClicked += new LinkLabelLinkClickedEventHandler( click );
                    link.Location = new Point( 5 , top );
                    panels[ i ].Controls.Add( link );

                }
                top += 30;
                link = new LinkLabel();
                link.Text = "更多";
                link.Tag = (Object) tags[i] == "所有類型" ? "原創;翻唱" : tags[ i ];
                link.LinkClicked += new LinkLabelLinkClickedEventHandler( more );
                link.Location = new Point( 5 , top );
                panels[ i ].Controls.Add( link );
            }
        }

        private void more( object sender , LinkLabelLinkClickedEventArgs e )
        {
            LinkLabel link = (LinkLabel) sender;
            FormMusicList formMusicList = new FormMusicList();
            formMusicList.TopLevel = false;
            formMusicList.Dock = DockStyle.Fill;
            formMusicList.FormBorderStyle = FormBorderStyle.None;
            FormMain.main.mainPanel.Controls.Add( formMusicList );
            formMusicList.BringToFront();

            foreach( CheckBox c in formMusicList.tag.Controls.OfType<CheckBox>().Where( r => ((String)link.Tag).Contains( r.Text ) ) )
            {
                c.Checked = true;
            }
            formMusicList.Show();
        }
        private void click( object sender , LinkLabelLinkClickedEventArgs e )
        {
            LinkLabel link = (LinkLabel) sender;
            select = (Music) link.Tag;
            addAccount.Visible = Account.islogin;
            musicList_Option.Show( link , new Point( link.Width - musicList_Option.Width , link.Height ) );
        }
        private void musicInfo_Click( object sender , EventArgs e )
        {
            FormMusicInfo formMusicInfo = new FormMusicInfo();
            formMusicInfo.TopLevel = false;
            formMusicInfo.Dock = DockStyle.Fill;
            formMusicInfo.FormBorderStyle = FormBorderStyle.None;
            FormMain.main.mainPanel.Controls.Add( formMusicInfo );
            formMusicInfo.BringToFront();
            formMusicInfo.Set( select );
            select = null;
            formMusicInfo.Show();
        }
        private void singerInfo_Click( object sender , EventArgs e )
        {
            FormMusicSinger formMusicSinger = new FormMusicSinger();
            formMusicSinger.TopLevel = false;
            formMusicSinger.Dock = DockStyle.Fill;
            formMusicSinger.FormBorderStyle = FormBorderStyle.None;
            FormMain.main.mainPanel.Controls.Add( formMusicSinger );
            formMusicSinger.BringToFront();
            formMusicSinger.Set( new Account( select ) );
            select = null;
            formMusicSinger.Show();
        }
        private void addCurrent_Click( object sender , EventArgs e )
        {
            MusicList.add( select , false );
            select = null;
        }
        private void addLocal_Click( object sender , EventArgs e )
        {
            MusicList.add( "local" , select );
            FormMain.main.refreshMusiclist();
            select = null;
        }
        private void addAccount_Click( object sender , EventArgs e )
        {
            MusicList.add( "account" , select );
            FormMain.main.refreshMusiclist();
            select = null;
        }
        private void play_Click( object sender , EventArgs e )
        {
            MusicList.add( select , true );
            select = null;
        }
    }
}
