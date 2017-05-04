namespace music
{
    partial class FormMusicList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.singer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musicInfo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.singerInfo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addMusicList = new System.Windows.Forms.DataGridViewButtonColumn();
            this.play = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tag = new System.Windows.Forms.GroupBox();
            this.tag_label1 = new System.Windows.Forms.Label();
            this.tag1 = new System.Windows.Forms.CheckBox();
            this.tag2 = new System.Windows.Forms.CheckBox();
            this.tag_label2 = new System.Windows.Forms.Label();
            this.tag3 = new System.Windows.Forms.CheckBox();
            this.tag8 = new System.Windows.Forms.CheckBox();
            this.tag7 = new System.Windows.Forms.CheckBox();
            this.tag4 = new System.Windows.Forms.CheckBox();
            this.tag6 = new System.Windows.Forms.CheckBox();
            this.tag5 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tag.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.singer,
            this.musicInfo,
            this.singerInfo,
            this.addMusicList,
            this.play});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(484, 311);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // singer
            // 
            this.singer.HeaderText = "singer";
            this.singer.Name = "singer";
            this.singer.ReadOnly = true;
            // 
            // musicInfo
            // 
            this.musicInfo.HeaderText = "musicInfo";
            this.musicInfo.Name = "musicInfo";
            this.musicInfo.ReadOnly = true;
            // 
            // singerInfo
            // 
            this.singerInfo.HeaderText = "singerInfo";
            this.singerInfo.Name = "singerInfo";
            this.singerInfo.ReadOnly = true;
            // 
            // addMusicList
            // 
            this.addMusicList.HeaderText = "addMusicList";
            this.addMusicList.Name = "addMusicList";
            this.addMusicList.ReadOnly = true;
            // 
            // play
            // 
            this.play.HeaderText = "play";
            this.play.Name = "play";
            this.play.ReadOnly = true;
            // 
            // tag
            // 
            this.tag.Controls.Add(this.tag_label1);
            this.tag.Controls.Add(this.tag1);
            this.tag.Controls.Add(this.tag2);
            this.tag.Controls.Add(this.tag_label2);
            this.tag.Controls.Add(this.tag3);
            this.tag.Controls.Add(this.tag8);
            this.tag.Controls.Add(this.tag7);
            this.tag.Controls.Add(this.tag4);
            this.tag.Controls.Add(this.tag6);
            this.tag.Controls.Add(this.tag5);
            this.tag.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag.Location = new System.Drawing.Point(0, 0);
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(484, 150);
            this.tag.TabIndex = 28;
            this.tag.TabStop = false;
            // 
            // tag_label1
            // 
            this.tag_label1.AutoSize = true;
            this.tag_label1.Location = new System.Drawing.Point(5, 25);
            this.tag_label1.Name = "tag_label1";
            this.tag_label1.Size = new System.Drawing.Size(73, 12);
            this.tag_label1.TabIndex = 12;
            this.tag_label1.Text = "分類(二擇一)";
            // 
            // tag1
            // 
            this.tag1.AutoSize = true;
            this.tag1.Location = new System.Drawing.Point(5, 50);
            this.tag1.Name = "tag1";
            this.tag1.Size = new System.Drawing.Size(48, 16);
            this.tag1.TabIndex = 15;
            this.tag1.Text = "原創";
            this.tag1.UseVisualStyleBackColor = true;
            this.tag1.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // tag2
            // 
            this.tag2.AutoSize = true;
            this.tag2.Location = new System.Drawing.Point(75, 50);
            this.tag2.Name = "tag2";
            this.tag2.Size = new System.Drawing.Size(48, 16);
            this.tag2.TabIndex = 16;
            this.tag2.Text = "翻唱";
            this.tag2.UseVisualStyleBackColor = true;
            this.tag2.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // tag_label2
            // 
            this.tag_label2.AutoSize = true;
            this.tag_label2.Location = new System.Drawing.Point(5, 75);
            this.tag_label2.Name = "tag_label2";
            this.tag_label2.Size = new System.Drawing.Size(53, 12);
            this.tag_label2.TabIndex = 21;
            this.tag_label2.Text = "音樂類型";
            // 
            // tag3
            // 
            this.tag3.AutoSize = true;
            this.tag3.Location = new System.Drawing.Point(5, 100);
            this.tag3.Name = "tag3";
            this.tag3.Size = new System.Drawing.Size(60, 16);
            this.tag3.TabIndex = 13;
            this.tag3.Text = "純音樂";
            this.tag3.UseVisualStyleBackColor = true;
            this.tag3.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // tag8
            // 
            this.tag8.AutoSize = true;
            this.tag8.Location = new System.Drawing.Point(75, 100);
            this.tag8.Name = "tag8";
            this.tag8.Size = new System.Drawing.Size(60, 16);
            this.tag8.TabIndex = 20;
            this.tag8.Text = "重金屬";
            this.tag8.UseVisualStyleBackColor = true;
            this.tag8.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // tag7
            // 
            this.tag7.AutoSize = true;
            this.tag7.Location = new System.Drawing.Point(75, 125);
            this.tag7.Name = "tag7";
            this.tag7.Size = new System.Drawing.Size(72, 16);
            this.tag7.TabIndex = 19;
            this.tag7.Text = "流行音樂";
            this.tag7.UseVisualStyleBackColor = true;
            this.tag7.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // tag4
            // 
            this.tag4.AutoSize = true;
            this.tag4.Location = new System.Drawing.Point(145, 100);
            this.tag4.Name = "tag4";
            this.tag4.Size = new System.Drawing.Size(48, 16);
            this.tag4.TabIndex = 14;
            this.tag4.Text = "搖滾";
            this.tag4.UseVisualStyleBackColor = true;
            this.tag4.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // tag6
            // 
            this.tag6.AutoSize = true;
            this.tag6.Location = new System.Drawing.Point(5, 125);
            this.tag6.Name = "tag6";
            this.tag6.Size = new System.Drawing.Size(60, 16);
            this.tag6.TabIndex = 18;
            this.tag6.Text = "輕音樂";
            this.tag6.UseVisualStyleBackColor = true;
            this.tag6.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // tag5
            // 
            this.tag5.AutoSize = true;
            this.tag5.Location = new System.Drawing.Point(215, 100);
            this.tag5.Name = "tag5";
            this.tag5.Size = new System.Drawing.Size(48, 16);
            this.tag5.TabIndex = 17;
            this.tag5.Text = "爵士";
            this.tag5.UseVisualStyleBackColor = true;
            this.tag5.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // FormMusicList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tag);
            this.Name = "FormMusicList";
            this.Text = "FormMusicList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tag.ResumeLayout(false);
            this.tag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn singer;
        private System.Windows.Forms.DataGridViewButtonColumn musicInfo;
        private System.Windows.Forms.DataGridViewButtonColumn singerInfo;
        private System.Windows.Forms.DataGridViewButtonColumn addMusicList;
        private System.Windows.Forms.DataGridViewButtonColumn play;
        private System.Windows.Forms.GroupBox tag;
        private System.Windows.Forms.Label tag_label1;
        private System.Windows.Forms.CheckBox tag1;
        private System.Windows.Forms.CheckBox tag2;
        private System.Windows.Forms.Label tag_label2;
        private System.Windows.Forms.CheckBox tag3;
        private System.Windows.Forms.CheckBox tag8;
        private System.Windows.Forms.CheckBox tag7;
        private System.Windows.Forms.CheckBox tag4;
        private System.Windows.Forms.CheckBox tag6;
        private System.Windows.Forms.CheckBox tag5;
    }
}