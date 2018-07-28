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
    public partial class entry : MetroForm

        
    {
        public entry()
        {
            InitializeComponent();
            List<String> ls = new List<string>() ;
            ls.Add("Saket");
            ls.Add("Dwarka");
            ls.Add("Tees Hazari");
            ls.Add("Rohini");
            ls.Add("High Court");
            ls.Add("Patiala House");
            ls.Add("Karkardooma");
            listBox1.DataSource = ls;

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            SqlConnection sq1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jatin\Documents\access.mdf;Integrated Security=True;Connect Timeout=30;");
            sq1.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Insert into table6613 (Case_Number,Client_Name,Title,Last_date_of_hearing,Next_date_of_hearing,Total_Fees,Fees_paid,Court_name,Mobile_number) Values ('"+metroTextBox1.Text.ToString()+"','"+metroTextBox2.Text.ToString()+"','"+metroTextBox3.Text.ToString()+"','"+metroTextBox4.Text.ToString()+"','"+metroTextBox5.Text.ToString()+"','"+metroTextBox6.Text.ToString()+"','"+metroTextBox7.Text.ToString()+"','"+listBox1.SelectedItem.ToString()+"','"+metroTextBox9.Text.ToString()+"')",sq1);
           // MessageBox.Show(@"Insert into table6613([Case_Number],[Client_Name],[Title],[Last_date_of_hearing],[Next_date_of_hearing],[Total_Fees],[Fees_paid],[Court_name],[Mobile_number]) Values ('" + metroTextBox1.Text.ToString() + "','" + metroTextBox2.Text.ToString() + "','" + metroTextBox3.Text.ToString() + "','" + metroTextBox4.Text.ToString() + "','" + metroTextBox5.Text.ToString() + "','" + metroTextBox6.Text.ToString() + "','" + metroTextBox7.Text.ToString() + "','" + metroTextBox8.Text.ToString() + "','" + metroTextBox9.Text.ToString() + "')");
            int r = sda.SelectCommand.ExecuteNonQuery();
            if(r>0)
            {
                MessageBox.Show("Data has been added!");
                metroTextBox1.Text = "";
                metroTextBox2.Text = "";
                metroTextBox3.Text = "";
                metroTextBox4.Text = "";
                metroTextBox5.Text = "";
                metroTextBox6.Text = "";
                metroTextBox7.Text = "";
               
                metroTextBox9.Text = "";
               

            }
            else
            {
                MessageBox.Show("Error occured! Contact Aayush!");
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
