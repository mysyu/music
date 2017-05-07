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
            this.tag = new System.Windows.Forms.Button();
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
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tag);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button tag;
    }
}