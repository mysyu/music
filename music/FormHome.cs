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
            formMusicList.Set( null , false );
            formMusicList.Show();
        }

        private void FormHome_Shown( object sender , EventArgs e )
        {
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
                panels[ i ].Controls.Clear();
                Label l = new Label();
                l.Text = tags[ i ] + " Top 10";
                l.Location = new Point( 5 , 5 );
                panels[ i ].Controls.Add( l );
            }
        }
    }
}
