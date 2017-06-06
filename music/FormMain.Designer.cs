using System.Drawing;

namespace music
{
    partial class FormMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.totalTime = new System.Windows.Forms.Label();
            this.music_Timer = new System.Windows.Forms.Timer(this.components);
            this.menuPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.home = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.Button();
            this.musicListPanel = new System.Windows.Forms.Panel();
            this.currentList = new System.Windows.Forms.Panel();
            this.lyrics = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.singer = new System.Windows.Forms.Label();
            this.currentTime = new System.Windows.Forms.Label();
            this.musicList = new System.Windows.Forms.TreeView();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.account_Option = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.account_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.account_music = new System.Windows.Forms.ToolStripMenuItem();
            this.upload = new System.Windows.Forms.ToolStripMenuItem();
            this.modify = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.network_Detect = new System.Windows.Forms.Timer(this.components);
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.musicList_Option = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.musicInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.singerInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.addCurrent = new System.Windows.Forms.ToolStripMenuItem();
            this.addLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.play = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.last = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.musicListPanel.SuspendLayout();
            this.currentList.SuspendLayout();
            this.account_Option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.musicList_Option.SuspendLayout();
            this.SuspendLayout();
            // 
            // totalTime
            // 
            this.totalTime.AutoSize = true;
            this.totalTime.Location = new System.Drawing.Point(10, 70);
            this.totalTime.Name = "totalTime";
            this.totalTime.Size = new System.Drawing.Size(101, 12);
            this.totalTime.TabIndex = 6;
            this.totalTime.Text = "歌曲時間     : 00:00";
            // 
            // music_Timer
            // 
            this.music_Timer.Tick += new System.EventHandler(this.music_Timer_Tick);
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.searchButton);
            this.menuPanel.Controls.Add(this.search);
            this.menuPanel.Controls.Add(this.home);
            this.menuPanel.Controls.Add(this.account);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1000, 45);
            this.menuPanel.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(615, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(206, 11);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(403, 22);
            this.search.TabIndex = 2;
            this.search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.search_KeyDown);
            // 
            // home
            // 
            this.home.Location = new System.Drawing.Point(0, 0);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(200, 45);
            this.home.TabIndex = 1;
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // account
            // 
            this.account.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.account.Location = new System.Drawing.Point(900, 11);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(75, 23);
            this.account.TabIndex = 0;
            this.account.Text = "登入";
            this.account.UseVisualStyleBackColor = true;
            this.account.Click += new System.EventHandler(this.account_Click);
            // 
            // musicListPanel
            // 
            this.musicListPanel.Controls.Add(this.currentList);
            this.musicListPanel.Controls.Add(this.musicList);
            this.musicListPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.musicListPanel.Location = new System.Drawing.Point(0, 45);
            this.musicListPanel.Name = "musicListPanel";
            this.musicListPanel.Size = new System.Drawing.Size(200, 500);
            this.musicListPanel.TabIndex = 11;
            // 
            // currentList
            // 
            this.currentList.Controls.Add(this.lyrics);
            this.currentList.Controls.Add(this.list);
            this.currentList.Controls.Add(this.name);
            this.currentList.Controls.Add(this.singer);
            this.currentList.Controls.Add(this.currentTime);
            this.currentList.Controls.Add(this.totalTime);
            this.currentList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.currentList.Location = new System.Drawing.Point(0, 400);
            this.currentList.Name = "currentList";
            this.currentList.Size = new System.Drawing.Size(200, 100);
            this.currentList.TabIndex = 2;
            // 
            // lyrics
            // 
            this.lyrics.Location = new System.Drawing.Point(117, 70);
            this.lyrics.Name = "lyrics";
            this.lyrics.Size = new System.Drawing.Size(75, 23);
            this.lyrics.TabIndex = 14;
            this.lyrics.Text = "顯示歌詞";
            this.lyrics.UseVisualStyleBackColor = true;
            this.lyrics.Click += new System.EventHandler(this.lyrics_Click);
            // 
            // list
            // 
            this.list.Location = new System.Drawing.Point(117, 45);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(75, 23);
            this.list.TabIndex = 13;
            this.list.Text = "播放列表";
            this.list.UseVisualStyleBackColor = true;
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(10, 10);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(74, 12);
            this.name.TabIndex = 9;
            this.name.Text = "歌曲名稱     : ";
            // 
            // singer
            // 
            this.singer.AutoSize = true;
            this.singer.Location = new System.Drawing.Point(10, 30);
            this.singer.Name = "singer";
            this.singer.Size = new System.Drawing.Size(74, 12);
            this.singer.TabIndex = 8;
            this.singer.Text = "創作者/團體: ";
            // 
            // currentTime
            // 
            this.currentTime.AutoSize = true;
            this.currentTime.Location = new System.Drawing.Point(10, 50);
            this.currentTime.Name = "currentTime";
            this.currentTime.Size = new System.Drawing.Size(101, 12);
            this.currentTime.TabIndex = 7;
            this.currentTime.Text = "目前時間     : 00:00";
            // 
            // musicList
            // 
            this.musicList.AllowDrop = true;
            this.musicList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.musicList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musicList.Location = new System.Drawing.Point(0, 0);
            this.musicList.Name = "musicList";
            this.musicList.Size = new System.Drawing.Size(200, 500);
            this.musicList.TabIndex = 1;
            this.musicList.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.musicList_NodeMouseClick);
            this.musicList.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.musicList_NodeMouseDoubleClick);
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 45);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 500);
            this.mainPanel.TabIndex = 12;
            // 
            // account_Option
            // 
            this.account_Option.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.account_Info,
            this.account_music,
            this.upload,
            this.modify,
            this.logout});
            this.account_Option.Name = "account_Option";
            this.account_Option.Size = new System.Drawing.Size(123, 114);
            // 
            // account_Info
            // 
            this.account_Info.Name = "account_Info";
            this.account_Info.Size = new System.Drawing.Size(122, 22);
            this.account_Info.Text = "個人資料";
            this.account_Info.Click += new System.EventHandler(this.account_Info_Click);
            // 
            // account_music
            // 
            this.account_music.Name = "account_music";
            this.account_music.Size = new System.Drawing.Size(122, 22);
            this.account_music.Text = "創作管理";
            this.account_music.Click += new System.EventHandler(this.account_music_Click);
            // 
            // upload
            // 
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(122, 22);
            this.upload.Text = "上傳音樂";
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // modify
            // 
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(122, 22);
            this.modify.Text = "變更密碼";
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // logout
            // 
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(122, 22);
            this.logout.Text = "登出";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "music";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // network_Detect
            // 
            this.network_Detect.Tick += new System.EventHandler(this.network_Detect_Tick);
            // 
            // musicPlayer
            // 
            this.musicPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(0, 545);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(1000, 45);
            this.musicPlayer.TabIndex = 1;
            this.musicPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.musicPlayer_PlayStateChange);
            // 
            // musicList_Option
            // 
            this.musicList_Option.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musicInfo,
            this.singerInfo,
            this.addCurrent,
            this.addLocal,
            this.addAccount,
            this.play,
            this.delete});
            this.musicList_Option.Name = "musicList_Option";
            this.musicList_Option.Size = new System.Drawing.Size(147, 158);
            // 
            // musicInfo
            // 
            this.musicInfo.Name = "musicInfo";
            this.musicInfo.Size = new System.Drawing.Size(146, 22);
            this.musicInfo.Text = "歌曲資訊";
            this.musicInfo.Click += new System.EventHandler(this.musicInfo_Click);
            // 
            // singerInfo
            // 
            this.singerInfo.Name = "singerInfo";
            this.singerInfo.Size = new System.Drawing.Size(146, 22);
            this.singerInfo.Text = "創作者資訊";
            this.singerInfo.Click += new System.EventHandler(this.singerInfo_Click);
            // 
            // addCurrent
            // 
            this.addCurrent.Name = "addCurrent";
            this.addCurrent.Size = new System.Drawing.Size(146, 22);
            this.addCurrent.Text = "加入播放歌單";
            this.addCurrent.Click += new System.EventHandler(this.addCurrent_Click);
            // 
            // addLocal
            // 
            this.addLocal.Name = "addLocal";
            this.addLocal.Size = new System.Drawing.Size(146, 22);
            this.addLocal.Text = "加入本機歌單";
            this.addLocal.Click += new System.EventHandler(this.addLocal_Click);
            // 
            // addAccount
            // 
            this.addAccount.Name = "addAccount";
            this.addAccount.Size = new System.Drawing.Size(146, 22);
            this.addAccount.Text = "加入帳戶歌單";
            this.addAccount.Click += new System.EventHandler(this.addAccount_Click);
            // 
            // play
            // 
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(146, 22);
            this.play.Text = "播放";
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(146, 22);
            this.delete.Text = "刪除";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // last
            // 
            this.last.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.last.Location = new System.Drawing.Point(65, 560);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(20, 20);
            this.last.TabIndex = 13;
            this.last.Text = "<";
            this.last.UseVisualStyleBackColor = true;
            this.last.Click += new System.EventHandler(this.last_Click);
            // 
            // next
            // 
            this.next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.next.Location = new System.Drawing.Point(91, 560);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(20, 20);
            this.next.TabIndex = 14;
            this.next.Text = ">";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 590);
            this.Controls.Add(this.next);
            this.Controls.Add(this.last);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.musicListPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.musicPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Text = "Music";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMain_KeyPress);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.musicListPanel.ResumeLayout(false);
            this.currentList.ResumeLayout(false);
            this.currentList.PerformLayout();
            this.account_Option.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            this.musicList_Option.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        public System.Windows.Forms.Label totalTime;
        public System.Windows.Forms.Timer music_Timer;
        public System.Windows.Forms.Panel menuPanel;
        public System.Windows.Forms.Panel musicListPanel;
        public System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.TreeView musicList;
        public System.Windows.Forms.Button account;
        public System.Windows.Forms.ContextMenuStrip account_Option;
        public System.Windows.Forms.ToolStripMenuItem account_Info;
        public System.Windows.Forms.ToolStripMenuItem account_music;
        public System.Windows.Forms.ToolStripMenuItem modify;
        public System.Windows.Forms.ToolStripMenuItem logout;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        public System.Windows.Forms.Timer network_Detect;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel currentList;
        public System.Windows.Forms.Label currentTime;
        public System.Windows.Forms.Label name;
        public System.Windows.Forms.Label singer;
        public System.Windows.Forms.Button lyrics;
        public System.Windows.Forms.Button list;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.ToolStripMenuItem upload;
        private System.Windows.Forms.ContextMenuStrip musicList_Option;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem addLocal;
        private System.Windows.Forms.ToolStripMenuItem addCurrent;
        private System.Windows.Forms.ToolStripMenuItem musicInfo;
        private System.Windows.Forms.ToolStripMenuItem singerInfo;
        private System.Windows.Forms.ToolStripMenuItem addAccount;
        private System.Windows.Forms.ToolStripMenuItem play;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button last;
    }
}

