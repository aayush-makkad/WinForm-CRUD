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
    public partial class delete_entry : MetroForm
    {
        public delete_entry()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            SqlConnection sq1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jatin\Documents\access.mdf;Integrated Security=True;Connect Timeout=30;");
            sq1.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Delete from table6613 where [Id] ='" + metroTextBox1.Text.ToString() + "'", sq1);
            int r = sda.SelectCommand.ExecuteNonQuery();
            if(r == 0)
            {
                MessageBox.Show("No row affected! correct id?");
            }
            else
            {
                MessageBox.Show("Done!");
            }
            sq1.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            panel p = new panel();
            p.Show();
            this.Hide();
        }
    }
}
