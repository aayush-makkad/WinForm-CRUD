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
    public partial class @case : MetroForm
    {

        SqlConnection sc;
        SqlDataAdapter sda;
        DataTable dt;
        public @case()
        {
            InitializeComponent();
        }

        private void case_Load(object sender, EventArgs e)
        {
            sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jatin\Documents\access.mdf;Integrated Security=True;Connect Timeout=30;");
            sda = new SqlDataAdapter("select [Case_Number],[Title],[Last_date_of_hearing],[Next_date_of_hearing] from table6613", sc);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            panel p = new panel();
            p.Show();
            this.Hide();
        }
    }
}
