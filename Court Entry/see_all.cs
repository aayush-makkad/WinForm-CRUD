using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace Court_Entry
{
    public partial class see_all : MetroForm
    {
        public see_all()
        {
            InitializeComponent();
           
           
        }

        private void addData()
        {
            metroButton1.Visible = false;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jatin\Documents\access.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select * from table6613 ", sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                ListViewItem lvi = new ListViewItem(dr["Id"].ToString());
                lvi.SubItems.Add(dr["Case_Number"].ToString());
                
                lvi.SubItems.Add(dr["Client_Name"].ToString());
                lvi.SubItems.Add(dr["Title"].ToString());
                lvi.SubItems.Add(dr["Last_date_of_hearing"].ToString());
                lvi.SubItems.Add(dr["Next_date_of_hearing"].ToString());
                lvi.SubItems.Add(dr["Total_Fees"].ToString());
                lvi.SubItems.Add(dr["Fees_paid"].ToString());
                lvi.SubItems.Add(dr["Court_name"].ToString());
                lvi.SubItems.Add(dr["Mobile_Number"].ToString());
                listView1.Items.Add(lvi);
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            addData();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            panel p = new panel();
            p.Show();
            this.Hide();
        }
    }
}
