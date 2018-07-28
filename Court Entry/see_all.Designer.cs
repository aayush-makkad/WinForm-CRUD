namespace Court_Entry
{
    partial class see_all
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Case_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.client_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ldoh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ndoh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.court = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = true;
            this.metroButton1.Location = new System.Drawing.Point(560, 26);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(134, 23);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Fetch Data";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Case_Number,
            this.client_name,
            this.title,
            this.ldoh,
            this.ndoh,
            this.total,
            this.paid,
            this.court,
            this.number});
            this.listView1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(9, 84);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1275, 433);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Case_Number
            // 
            this.Case_Number.Text = "Case Number";
            this.Case_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Case_Number.Width = 150;
            // 
            // client_name
            // 
            this.client_name.Text = "Client Name";
            this.client_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.client_name.Width = 150;
            // 
            // title
            // 
            this.title.Text = "Title";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.Width = 203;
            // 
            // ldoh
            // 
            this.ldoh.Text = "Last date of hearing";
            this.ldoh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ldoh.Width = 100;
            // 
            // ndoh
            // 
            this.ndoh.Text = "Next date of hearing";
            this.ndoh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ndoh.Width = 100;
            // 
            // total
            // 
            this.total.Text = "Total fees";
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.total.Width = 100;
            // 
            // paid
            // 
            this.paid.Text = "Fees paid ";
            this.paid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.paid.Width = 100;
            // 
            // court
            // 
            this.court.Text = "Court Name";
            this.court.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.court.Width = 100;
            // 
            // number
            // 
            this.number.Text = "Mobile number";
            this.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.number.Width = 200;
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = true;
            this.metroButton2.Location = new System.Drawing.Point(9, 55);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(106, 23);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Main Menu";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // see_all
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 549);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.metroButton1);
            this.Name = "see_all";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "All Data";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Case_Number;
        private System.Windows.Forms.ColumnHeader client_name;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader ldoh;
        private System.Windows.Forms.ColumnHeader ndoh;
        private System.Windows.Forms.ColumnHeader total;
        private System.Windows.Forms.ColumnHeader paid;
        private System.Windows.Forms.ColumnHeader court;
        private System.Windows.Forms.ColumnHeader number;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}