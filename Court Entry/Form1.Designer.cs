namespace Court_Entry
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.user_text = new MetroFramework.Controls.MetroLabel();
            this.pass_text = new MetroFramework.Controls.MetroLabel();
            this.user = new MetroFramework.Controls.MetroTextBox();
            this.pass = new MetroFramework.Controls.MetroTextBox();
            this.login = new MetroFramework.Controls.MetroButton();
            this.exit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // user_text
            // 
            this.user_text.AutoSize = true;
            this.user_text.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.user_text.Location = new System.Drawing.Point(104, 124);
            this.user_text.Name = "user_text";
            this.user_text.Size = new System.Drawing.Size(95, 19);
            this.user_text.Style = MetroFramework.MetroColorStyle.Red;
            this.user_text.TabIndex = 0;
            this.user_text.Text = "User Name : ";
            this.user_text.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.user_text.UseStyleColors = true;
            // 
            // pass_text
            // 
            this.pass_text.AutoSize = true;
            this.pass_text.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.pass_text.Location = new System.Drawing.Point(104, 191);
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(89, 19);
            this.pass_text.Style = MetroFramework.MetroColorStyle.Red;
            this.pass_text.TabIndex = 1;
            this.pass_text.Text = "Password :  ";
            this.pass_text.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pass_text.UseStyleColors = true;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(278, 120);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(363, 23);
            this.user.Style = MetroFramework.MetroColorStyle.Red;
            this.user.TabIndex = 2;
            this.user.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.user.UseStyleColors = true;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(278, 187);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '●';
            this.pass.Size = new System.Drawing.Size(363, 23);
            this.pass.Style = MetroFramework.MetroColorStyle.Red;
            this.pass.TabIndex = 3;
            this.pass.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.pass.UseStyleColors = true;
            this.pass.UseSystemPasswordChar = true;
            // 
            // login
            // 
            this.login.Highlight = true;
            this.login.Location = new System.Drawing.Point(536, 271);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(105, 23);
            this.login.Style = MetroFramework.MetroColorStyle.Red;
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // exit
            // 
            this.exit.Highlight = true;
            this.exit.Location = new System.Drawing.Point(391, 270);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(93, 23);
            this.exit.Style = MetroFramework.MetroColorStyle.Red;
            this.exit.TabIndex = 5;
            this.exit.Text = "Exit";
            this.exit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 349);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.pass_text);
            this.Controls.Add(this.user_text);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel user_text;
        private MetroFramework.Controls.MetroLabel pass_text;
        private MetroFramework.Controls.MetroTextBox user;
        private MetroFramework.Controls.MetroTextBox pass;
        private MetroFramework.Controls.MetroButton login;
        private MetroFramework.Controls.MetroButton exit;
    }
}

