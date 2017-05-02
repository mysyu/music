namespace music
{
    partial class FormMusicLyrics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.name = new System.Windows.Forms.Label();
            this.singer = new System.Windows.Forms.Label();
            this.lyrics = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Dock = System.Windows.Forms.DockStyle.Top;
            this.name.Font = new System.Drawing.Font("新細明體", 20F);
            this.name.Location = new System.Drawing.Point(0, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(484, 50);
            this.name.TabIndex = 0;
            this.name.Text = "歌曲";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // singer
            // 
            this.singer.Dock = System.Windows.Forms.DockStyle.Top;
            this.singer.Font = new System.Drawing.Font("新細明體", 15F);
            this.singer.Location = new System.Drawing.Point(0, 50);
            this.singer.Name = "singer";
            this.singer.Size = new System.Drawing.Size(484, 53);
            this.singer.TabIndex = 1;
            this.singer.Text = "演唱者";
            this.singer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lyrics
            // 
            this.lyrics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lyrics.FormattingEnabled = true;
            this.lyrics.ItemHeight = 12;
            this.lyrics.Location = new System.Drawing.Point(0, 103);
            this.lyrics.Name = "lyrics";
            this.lyrics.Size = new System.Drawing.Size(484, 358);
            this.lyrics.TabIndex = 2;
            this.lyrics.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lyrics_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMusicLyrics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lyrics);
            this.Controls.Add(this.singer);
            this.Controls.Add(this.name);
            this.Name = "FormMusicLyrics";
            this.Text = "FormMusicLyrics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label singer;
        private System.Windows.Forms.ListBox lyrics;
        public System.Windows.Forms.Timer timer1;
    }
}