namespace music
{
    partial class FormLogin
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
            this.email_Label = new System.Windows.Forms.Label();
            this.password_Label = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // email_Label
            // 
            this.email_Label.AutoSize = true;
            this.email_Label.Location = new System.Drawing.Point(46, 46);
            this.email_Label.Name = "email_Label";
            this.email_Label.Size = new System.Drawing.Size(32, 12);
            this.email_Label.TabIndex = 0;
            this.email_Label.Text = "Email";
            // 
            // password_Label
            // 
            this.password_Label.AutoSize = true;
            this.password_Label.Location = new System.Drawing.Point(46, 90);
            this.password_Label.Name = "password_Label";
            this.password_Label.Size = new System.Drawing.Size(48, 12);
            this.password_Label.TabIndex = 2;
            this.password_Label.Text = "Password";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(48, 137);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 4;
            this.login.Text = "login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(105, 43);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 22);
            this.email.TabIndex = 5;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(105, 87);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(100, 22);
            this.password.TabIndex = 6;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.login);
            this.Controls.Add(this.password_Label);
            this.Controls.Add(this.email_Label);
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email_Label;
        private System.Windows.Forms.Label password_Label;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
    }
}