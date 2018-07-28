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
    public partial class panel : MetroForm
    {

        SqlConnection sc;
        SqlDataAdapter sda;
        DataTable dt;
        public panel()
        {
            InitializeComponent();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            see_all sa = new see_all();
            sa.Show();
            this.Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            entry e2 = new entry();
            e2.Show();
            this.Hide();
;
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            delete_entry de = new delete_entry();
            de.Show();
            this.Close();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            update_entry ue = new update_entry();
            ue.Show();
            this.Hide();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            client c = new client();
            c.Show();
            this.Hide();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            @case c = new @case();
            c.Show();
            this.Hide();
        }
        private void metroTile7_Click(object sender, EventArgs e)
        {
            printer p = new printer();
            p.Show();
            this.Hide();
        }

        private void panel_Load(object sender, EventArgs e)
        {
           String date =  DateTime.Today.ToString("dd/MM/yyyy");
            sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jatin\Documents\access.mdf;Integrated Security=True;Connect Timeout=30;");
            sda = new SqlDataAdapter("select [Case_Number],[Client_Name],[Title],[Last_date_of_hearing],[Next_date_of_hearing],[Court_name],[Mobile_number] from table6613 where [Next_date_of_hearing] ='"+date+"'", sc);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
