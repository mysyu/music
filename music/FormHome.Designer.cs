namespace music
{
    partial class FormHome
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
            this.tag = new System.Windows.Forms.Button();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.musicList_Option = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.musicInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.singerInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.addCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.play = new System.Windows.Forms.ToolStripMenuItem();
            this.musicList_Option.SuspendLayout();
            this.SuspendLayout();
            // 
            // tag
            // 
            this.tag.Location = new System.Drawing.Point(12, 12);
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(75, 23);
            this.tag.TabIndex = 5;
            this.tag.Text = "分類搜尋";
            this.tag.UseVisualStyleBackColor = true;
            this.tag.Click += new System.EventHandler(this.tag_Click);
            // 
            // table
            // 
            this.table.AutoSize = true;
            this.table.ColumnCount = 4;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.table.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.table.Location = new System.Drawing.Point(0, 461);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(501, 0);
            this.table.TabIndex = 6;
            // 
            // musicList_Option
            // 
            this.musicList_Option.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicInfo,
            this.singerInfo,
            this.addCurrent,
            this.addLocal,
            this.addAccount,
            this.play});
            this.musicList_Option.Name = "musicList_Option";
            this.musicList_Option.Size = new System.Drawing.Size(147, 136);
            // 
            // musicInfo
            // 
            this.musicInfo.Name = "musicInfo";
            this.musicInfo.Size = new System.Drawing.Size(152, 22);
            this.musicInfo.Text = "歌曲資訊";
            this.musicInfo.Click += new System.EventHandler(this.musicInfo_Click);
            // 
            // singerInfo
            // 
            this.singerInfo.Name = "singerInfo";
            this.singerInfo.Size = new System.Drawing.Size(152, 22);
            this.singerInfo.Text = "創作者資訊";
            this.singerInfo.Click += new System.EventHandler(this.singerInfo_Click);
            // 
            // addCurrent
            // 
            this.addCurrent.Name = "addCurrent";
            this.addCurrent.Size = new System.Drawing.Size(152, 22);
            this.addCurrent.Text = "加入播放歌單";
            this.addCurrent.Click += new System.EventHandler(this.addCurrent_Click);
            // 
            // addLocal
            // 
            this.addLocal.Name = "addLocal";
            this.addLocal.Size = new System.Drawing.Size(152, 22);
            this.addLocal.Text = "加入本機歌單";
            this.addLocal.Click += new System.EventHandler(this.addLocal_Click);
            // 
            // addAccount
            // 
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(152, 22);
            this.addAccount.Text = "加入帳戶歌單";
            this.addAccount.Click += new System.EventHandler(this.addAccount_Click);
            // 
            // play
            // 
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(152, 22);
            this.play.Text = "播放";
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.ClientSize = new System.Drawing.Size(501, 461);
            this.Controls.Add(this.tag);
            this.Controls.Add(this.table);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.Shown += new System.EventHandler(this.FormHome_Shown);
            this.musicList_Option.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button tag;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.ContextMenuStrip musicList_Option;
        private System.Windows.Forms.ToolStripMenuItem musicInfo;
        private System.Windows.Forms.ToolStripMenuItem singerInfo;
        private System.Windows.Forms.ToolStripMenuItem addCurrent;
        private System.Windows.Forms.ToolStripMenuItem addLocal;
        private System.Windows.Forms.ToolStripMenuItem addAccount;
        private System.Windows.Forms.ToolStripMenuItem play;
    }
}