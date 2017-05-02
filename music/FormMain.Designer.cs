﻿namespace music
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.account = new System.Windows.Forms.Button();
            this.musicListPanel = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.account_Option = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.account_Info = new System.Windows.Forms.ToolStripMenuItem();
            this.account_music = new System.Windows.Forms.ToolStripMenuItem();
            this.modify = new System.Windows.Forms.ToolStripMenuItem();
            this.logout = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.network_Detect = new System.Windows.Forms.Timer(this.components);
            this.musicPlayer = new music.MusicPlayer();
            this.menuPanel.SuspendLayout();
            this.musicListPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.account_Option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 299);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(473, 193);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(39, 81);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Input";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(529, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(258, 412);
            this.listBox1.TabIndex = 8;
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.account);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1000, 45);
            this.menuPanel.TabIndex = 10;
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
            this.musicListPanel.Controls.Add(this.treeView1);
            this.musicListPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.musicListPanel.Location = new System.Drawing.Point(0, 45);
            this.musicListPanel.Name = "musicListPanel";
            this.musicListPanel.Size = new System.Drawing.Size(200, 500);
            this.musicListPanel.TabIndex = 11;
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(200, 500);
            this.treeView1.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.button6);
            this.mainPanel.Controls.Add(this.button4);
            this.mainPanel.Controls.Add(this.listBox1);
            this.mainPanel.Controls.Add(this.textBox1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 45);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 500);
            this.mainPanel.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(39, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "current";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // account_Option
            // 
            this.account_Option.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.account_Info,
            this.account_music,
            this.modify,
            this.logout});
            this.account_Option.Name = "account_Option";
            this.account_Option.Size = new System.Drawing.Size(123, 92);
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
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.musicListPanel);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.musicPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formMain_FormClosing);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.menuPanel.ResumeLayout(false);
            this.musicListPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.account_Option.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MusicPlayer musicPlayer;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.Panel menuPanel;
        public System.Windows.Forms.Panel musicListPanel;
        public System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.Button account;
        public System.Windows.Forms.ContextMenuStrip account_Option;
        public System.Windows.Forms.ToolStripMenuItem account_Info;
        public System.Windows.Forms.ToolStripMenuItem account_music;
        public System.Windows.Forms.ToolStripMenuItem modify;
        public System.Windows.Forms.ToolStripMenuItem logout;
        public System.Windows.Forms.NotifyIcon notifyIcon;
        public System.Windows.Forms.Timer network_Detect;
        private System.Windows.Forms.Button button6;
    }
}

