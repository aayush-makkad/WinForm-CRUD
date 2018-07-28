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
    public partial class client : MetroForm
    {
        SqlConnection sc;
        SqlDataAdapter sda;
        DataTable dt;

        public client()
        {
            InitializeComponent();
        }

        private void client_Load(object sender, EventArgs e)
        {
            sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jatin\Documents\access.mdf;Integrated Security=True;Connect Timeout=30;");
            sda = new SqlDataAdapter("select [Client_Name],[Total_Fees],[Fees_paid],[Mobile_number] from table6613", sc);
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
