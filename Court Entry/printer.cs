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
using iTextSharp.text;
using iTextSharp.awt;
using iTextSharp.testutils;
using iTextSharp.xmp;
using iTextSharp.text.pdf;
using System.Data.SqlClient;
using System.IO;
using System.Diagnostics;
using System.Drawing.Printing;
using PdfiumViewer;

namespace Court_Entry
{
    public partial class printer : MetroForm
    {
        SqlConnection sc;
        SqlDataAdapter sda,sda2,sda3,sda4,sda5,sda6,sda7;
        DataTable dt,dt2,dt3,dt4,dt5,dt6,dt7;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        Document d;
        
        public printer()
        {
            InitializeComponent();
            String date = DateTime.Today.ToString("dd/MM/yyyy");
            DateTime dte = DateTime.Now.Date;
            String dte2 = dte.AddDays(1).ToString("dd/MM/yyyy");
            String dte3 = dte.AddDays(2).ToString("dd/MM/yyyy");
            String dte4 = dte.AddDays(3).ToString("dd/MM/yyyy");
            String dte5 = dte.AddDays(4).ToString("dd/MM/yyyy");
            String dte6 = dte.AddDays(5).ToString("dd/MM/yyyy");
            String dte7 = dte.AddDays(6).ToString("dd/MM/yyyy");
            sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Jatin\Documents\access.mdf;Integrated Security=True;Connect Timeout=30;");
            sda = new SqlDataAdapter("select [Case_Number],[Client_Name],[Title],[Last_date_of_hearing],[Next_date_of_hearing],[Court_name],[Mobile_number] from table6613 where [Court_name] = 'Dwarka' AND ([Next_date_of_hearing] ='" + date + "' or [Next_date_of_hearing] ='" +dte2+ "' or [Next_date_of_hearing] = '"+dte3+"' or [Next_date_of_hearing] = '"+dte4+"' or [Next_date_of_hearing] = '"+dte5+"' or [Next_date_of_hearing] = '"+dte6+"' or [Next_date_of_hearing] = '"+dte7+"')", sc);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            // sda2 = new SqlDataAdapter("select [Case_Number],[Client_Name],[Title],[Last_date_of_hearing],[Next_date_of_hearing],[Court_name],[Mobile_number] from table6613 where [Next_date_of_hearing] ='" + date + "' or [Next_date_of_hearing] ='" + dte2 + "' or [Next_date_of_hearing] = '" + dte3 + "' or [Next_date_of_hearing] = '" + dte4 + "' or [Next_date_of_hearing] = '" + dte5 + "' or [Next_date_of_hearing] = '" + dte6 + "' or [Next_date_of_hearing] = '" + dte7 + "' and [Court_name] = 'Saket'", sc);
            sda2 = new SqlDataAdapter("select [Case_Number],[Client_Name],[Title],[Last_date_of_hearing],[Next_date_of_hearing],[Court_name],[Mobile_number] from table6613 where [Court_name] = 'High Court' AND ([Next_date_of_hearing] ='" + date + "' or [Next_date_of_hearing] ='" + dte2 + "' or [Next_date_of_hearing] = '" + dte3 + "' or [Next_date_of_hearing] = '" + dte4 + "' or [Next_date_of_hearing] = '" + dte5 + "' or [Next_date_of_hearing] = '" + dte6 + "' or [Next_date_of_hearing] = '" + dte7 + "')", sc);
            dt2 = new DataTable();
            sda2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            sda3 = new SqlDataAdapter("select [Case_Number],[Client_Name],[Title],[Last_date_of_hearing],[Next_date_of_hearing],[Court_name],[Mobile_number] from table6613 where [Court_name] = 'Saket' AND ([Next_date_of_hearing] ='" + date + "' or [Next_date_of_hearing] ='" + dte2 + "' or [Next_date_of_hearing] = '" + dte3 + "' or [Next_date_of_hearing] = '" + dte4 + "' or [Next_date_of_hearing] = '" + dte5 + "' or [Next_date_of_hearing] = '" + dte6 + "' or [Next_date_of_hearing] = '" + dte7 + "')", sc);
            // sda3 = new SqlDataAdapter("select [Case_Number],[Client_Name],[Title],[Last_date_of_hearing],[Next_date_of_hearing],[Court_name],[Mobile_number] from table6613 where [Next_date_of_hearing] ='" + date + "' or [Next_date_of_hearing] ='" + dte2 + "' or [Next_date_of_hearing] = '" + dte3 + "' or [Next_date_of_hearing] = '" + dte4 + "' or [Next_date_of_hearing] = '" + dte5 + "' or [Next_date_of_hearing] = '" + dte6 + "' or [Next_date_of_hearing] = '" + dte7 + "' and [Court_name] = 'Tees hazari'", sc);
            dt3 = new DataTable();
            sda3.Fill(dt3);
            dataGridView3.DataSource = dt3;

            sda4 = new SqlDataAdapter("select [Case_Number],[Client_Name],[Title],[Last_date_of_hearing],[Next_date_of_hearing],[Court_name],[Mobile_number] from table6613 where [Court_name] = 'Tees hazari' AND ([Next_date_of_hearing] ='" + date + "' or [Next_date_of_hearing] ='" + dte2 + "' or [Next_date_of_hearing] = '" + dte3 + "' or [Next_date_of_hearing] = '" + dte4 + "' or [Next_date_of_hearing] = '" + dte5 + "' or [Next_date_of_hearing] = '" + dte6 + "' or [Next_date_of_hearing] = '" + dte7 + "')", sc);
            // sda4 = new SqlDataAdapter("select [Case_Number],[Client_Name],[Title],[Last_date_of_hearing],[Next_date_of_hearing],[Court_name],[Mobile_number] from table6613 where [Next_date_of_hearing] ='" + date + "' or [Next_date_of_hearing] ='" + dte2 + "' or [Next_date_of_hearing] = '" + dte3 + "' or [Next_date_of_hearing] = '" + dte4 + "' or [Next_date_of_hearing] = '" + dte5 + "' or [Next_date_of_hearing] = '" + dte6 + "' or [Next_date_of_hearing] = '" + dte7 + "' and [Court_name] = 'Saket'", sc);
            dt4 = new DataTable();
            sda4.Fill(dt4);
            dataGridView4.DataSource = dt4;

            sda5 = new SqlDataAdapter("select [Case_Number],[Client_Name],[Title],[Last_date_of_hearing],[Next_date_of_hearing],[Court_name],[Mobile_number] from table6613 where [Court_name] = 'Rohini' AND ([Next_date_of_hearing] ='" + date + "' or [Next_date_of_hearing] ='" + dte2 + "' or [Next_date_of_hearing] = '" + dte3 + "' or [Next_date_of_hearing] = '" + dte4 + "' or [Next_date_of_hearing] = '" + dte5 + "' or [Next_date_of_hearing] = '" + dte6 + "' or [Next_date_of_hearing] = '" + dte7 + "')", sc);
            //  sda5 = new SqlDataAdapter("select [Case_Number],[Client_Name],[Title],[Last_date_of_hearing],[Next_date_of_hearing],[Court_name],[Mobile_number] from table6613 where [Next_date_of_hearing] ='" + date + "' or [Next_date_of_hearing] ='" + dte2 + "' or [Next_date_of_hearing] = '" + dte3 + "' or [Next_date_of_hearing] = '" + dte4 + "' or [Next_date_of_hearing] = '" + dte5 + "' or [Next_date_of_hearing] = '" + dte6 + "' or [Next_date_of_hearing] = '" + dte7 + "' and [Court_name] = 'Rohini'", sc);
            dt5 = new DataTable();
            sda5.Fill(dt5);
            dataGridView5.DataSource = dt5;


            sda6 = new SqlDataAdapter("select [Case_Number],[Client_Name],[Title],[Last_date_of_hearing],[Next_date_of_hearing],[Court_name],[Mobile_number] from table6613 where [Court_name] = 'Patiala House' AND ([Next_date_of_hearing] ='" + date + "' or [Next_date_of_hearing] ='" + dte2 + "' or [Next_date_of_hearing] = '" + dte3 + "' or [Next_date_of_hearing] = '" + dte4 + "' or [Next_date_of_hearing] = '" + dte5 + "' or [Next_date_of_hearing] = '" + dte6 + "' or [Next_date_of_hearing] = '" + dte7 + "')", sc);
            //  sda5 = new SqlDataAdapter("select [Case_Number],[Client_Name],[Title],[Last_date_of_hearing],[Next_date_of_hearing],[Court_name],[Mobile_number] from table6613 where [Next_date_of_hearing] ='" + date + "' or [Next_date_of_hearing] ='" + dte2 + "' or [Next_date_of_hearing] = '" + dte3 + "' or [Next_date_of_hearing] = '" + dte4 + "' or [Next_date_of_hearing] = '" + dte5 + "' or [Next_date_of_hearing] = '" + dte6 + "' or [Next_date_of_hearing] = '" + dte7 + "' and [Court_name] = 'Rohini'", sc);
            dt6 = new DataTable();
            sda6.Fill(dt6);
            dataGridView6.DataSource = dt6;


            sda7 = new SqlDataAdapter("select [Case_Number],[Client_Name],[Title],[Last_date_of_hearing],[Next_date_of_hearing],[Court_name],[Mobile_number] from table6613 where [Court_name] = 'Karkardooma' AND ([Next_date_of_hearing] ='" + date + "' or [Next_date_of_hearing] ='" + dte2 + "' or [Next_date_of_hearing] = '" + dte3 + "' or [Next_date_of_hearing] = '" + dte4 + "' or [Next_date_of_hearing] = '" + dte5 + "' or [Next_date_of_hearing] = '" + dte6 + "' or [Next_date_of_hearing] = '" + dte7 + "')", sc);
            //  sda5 = new SqlDataAdapter("select [Case_Number],[Client_Name],[Title],[Last_date_of_hearing],[Next_date_of_hearing],[Court_name],[Mobile_number] from table6613 where [Next_date_of_hearing] ='" + date + "' or [Next_date_of_hearing] ='" + dte2 + "' or [Next_date_of_hearing] = '" + dte3 + "' or [Next_date_of_hearing] = '" + dte4 + "' or [Next_date_of_hearing] = '" + dte5 + "' or [Next_date_of_hearing] = '" + dte6 + "' or [Next_date_of_hearing] = '" + dte7 + "' and [Court_name] = 'Rohini'", sc);
            dt7 = new DataTable();
            sda7.Fill(dt7);
            dataGridView7.DataSource = dt7;







        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            d = new Document(iTextSharp.text.PageSize.A4,10,10,60,30);
            PdfWriter wri = PdfWriter.GetInstance(d, new FileStream("test.pdf", FileMode.Create));
            d.Open();
            iTextSharp.text.Font f1 = FontFactory.GetFont("Lucida Sans", "122", Font.Underline);
            PdfPTable m = new PdfPTable(1);


    
            m.AddCell(new PdfPCell() { HorizontalAlignment = PdfPCell.ALIGN_CENTER, Phrase = new Phrase("JAI MAA VAISHNO DEVI \n"),BorderColor = BaseColor.WHITE,BorderWidth = 0 });
            d.Add(m);
            
            PdfPTable m2 = new PdfPTable(1);

            m2.AddCell(new PdfPCell() { HorizontalAlignment = PdfPCell.ALIGN_CENTER, Phrase = new Phrase("JAI MAA JHANDEWALI \n"), BorderColor = BaseColor.WHITE, BorderWidth = 0 });
            d.Add(m2);
         
            PdfPTable m3 = new PdfPTable(1);

            m3.AddCell(new PdfPCell() { HorizontalAlignment = PdfPCell.ALIGN_CENTER, Phrase = new Phrase("JAI OM SHANKAR BHAGWAN \n"), BorderColor = BaseColor.WHITE, BorderWidth = 0 });
            d.Add(m3);
            PdfPTable m4 = new PdfPTable(1);

            m4.AddCell(new PdfPCell() { HorizontalAlignment = PdfPCell.ALIGN_CENTER, Phrase = new Phrase("Sunita Seth's Law Firm \n"), BorderColor = BaseColor.WHITE, BorderWidth = 0 });
            d.Add(m4);

            PdfPTable m5 = new PdfPTable(1);

            m5.AddCell(new PdfPCell() { HorizontalAlignment = PdfPCell.ALIGN_LEFT, Phrase = new Phrase("Jatin seth \n"), BorderColor = BaseColor.WHITE, BorderWidth = 0 });
            d.Add(m5);

            PdfPTable m6 = new PdfPTable(1);

            m6.AddCell(new PdfPCell() { HorizontalAlignment = PdfPCell.ALIGN_LEFT, Phrase = new Phrase("Advocate \n"), BorderColor = BaseColor.WHITE, BorderWidth = 0 });
            d.Add(m6);

            PdfPTable m7 = new PdfPTable(1);

            m7.AddCell(new PdfPCell() { HorizontalAlignment = PdfPCell.ALIGN_LEFT, Phrase = new Phrase("Mob : 9599696060 \n\n\n"), BorderColor = BaseColor.WHITE, BorderWidth = 0 });
            d.Add(m7);


            PdfPTable m8 = new PdfPTable(1);

            m8.AddCell(new PdfPCell() { HorizontalAlignment = PdfPCell.ALIGN_LEFT, Phrase = new Phrase("Dwarka\n"), BorderColor = BaseColor.WHITE, BorderWidth = 0 });
            d.Add(m8);

            m.DefaultCell.HasBorder(iTextSharp.text.Rectangle.NO_BORDER);

           PdfPTable p = new PdfPTable(dataGridView1.Columns.Count);
         //   p.DefaultCell.Border = iTextSharp.text.Rectangle.NO_BORDER;
            for(int j=0;j<dataGridView1.Columns.Count;j++)
            {
                p.AddCell(new Phrase(dataGridView1.Columns[j].HeaderText));
            }
            p.HeaderRows = 1;
            for(int i=0;i<dataGridView1.Rows.Count;i++)
            {
                for(int k=0;k<dataGridView1.Columns.Count;k++)
                {
                    if(dataGridView1[k,i].Value!=null)
                    p.AddCell(new Phrase(dataGridView1[k, i].Value.ToString()));
                }
            }
            d.Add(p);


            PdfPTable m9 = new PdfPTable(1);

            m9.AddCell(new PdfPCell() { HorizontalAlignment = PdfPCell.ALIGN_LEFT, Phrase = new Phrase("High court\n"), BorderColor = BaseColor.WHITE, BorderWidth = 0 });
            d.Add(m9);

            m.DefaultCell.HasBorder(iTextSharp.text.Rectangle.NO_BORDER);

            PdfPTable p2 = new PdfPTable(dataGridView1.Columns.Count);
            for (int j = 0; j < dataGridView2.Columns.Count; j++)
            {
                p2.AddCell(new Phrase(dataGridView2.Columns[j].HeaderText));
            }
            p2.HeaderRows = 1;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView2.Columns.Count; k++)
                {
                    if (dataGridView2[k, i].Value != null)
                        p2.AddCell(new Phrase(dataGridView2[k, i].Value.ToString()));
                }
            }
            d.Add(p2);


            PdfPTable m10 = new PdfPTable(1);

            m10.AddCell(new PdfPCell() { HorizontalAlignment = PdfPCell.ALIGN_LEFT, Phrase = new Phrase("Saket\n"), BorderColor = BaseColor.WHITE, BorderWidth = 0 });
            d.Add(m10);

            m.DefaultCell.HasBorder(iTextSharp.text.Rectangle.NO_BORDER);

            PdfPTable p3 = new PdfPTable(dataGridView3.Columns.Count);
            
            for (int j = 0; j < dataGridView3.Columns.Count; j++)
            {
                p3.AddCell(new Phrase(dataGridView3.Columns[j].HeaderText));
            }
            p3.HeaderRows = 1;
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView3.Columns.Count; k++)
                {
                    if (dataGridView3[k, i].Value != null)
                        p3.AddCell(new Phrase(dataGridView3[k, i].Value.ToString()));
                }
            }
            d.Add(p3);


            PdfPTable m11 = new PdfPTable(1);

            m11.AddCell(new PdfPCell() { HorizontalAlignment = PdfPCell.ALIGN_LEFT, Phrase = new Phrase("Tees hazari\n"), BorderColor = BaseColor.WHITE, BorderWidth = 0 });
            d.Add(m11);

            m.DefaultCell.HasBorder(iTextSharp.text.Rectangle.NO_BORDER);

            PdfPTable p4 = new PdfPTable(dataGridView4.Columns.Count);
            for (int j = 0; j < dataGridView4.Columns.Count; j++)
            {
                p4.AddCell(new Phrase(dataGridView4.Columns[j].HeaderText));
            }
            p4.HeaderRows = 1;
            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView4.Columns.Count; k++)
                {
                    if (dataGridView4[k, i].Value != null)
                        p4.AddCell(new Phrase(dataGridView4[k, i].Value.ToString()));
                }
            }
            d.Add(p4);


            PdfPTable m12 = new PdfPTable(1);

            m12.AddCell(new PdfPCell() { HorizontalAlignment = PdfPCell.ALIGN_LEFT, Phrase = new Phrase("Rohini\n"), BorderColor = BaseColor.WHITE, BorderWidth = 0 });
            d.Add(m12);

            m.DefaultCell.HasBorder(iTextSharp.text.Rectangle.NO_BORDER);

            PdfPTable p5 = new PdfPTable(dataGridView5.Columns.Count);
            for (int j = 0; j < dataGridView5.Columns.Count; j++)
            {
                p5.AddCell(new Phrase(dataGridView5.Columns[j].HeaderText));
            }
            p5.HeaderRows = 1;
            for (int i = 0; i < dataGridView5.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView5.Columns.Count; k++)
                {
                    if (dataGridView5[k, i].Value != null)
                        p5.AddCell(new Phrase(dataGridView5[k, i].Value.ToString()));
                }
            }
            d.Add(p5);


            PdfPTable m13 = new PdfPTable(1);

            m13.AddCell(new PdfPCell() { HorizontalAlignment = PdfPCell.ALIGN_LEFT, Phrase = new Phrase("Patiala House\n"), BorderColor = BaseColor.WHITE, BorderWidth = 0 });
            d.Add(m13);

            m.DefaultCell.HasBorder(iTextSharp.text.Rectangle.NO_BORDER);

            PdfPTable p6 = new PdfPTable(dataGridView1.Columns.Count);
            for (int j = 0; j < dataGridView6.Columns.Count; j++)
            {
                p6.AddCell(new Phrase(dataGridView6.Columns[j].HeaderText));
            }
            p6.HeaderRows = 1;
            for (int i = 0; i < dataGridView6.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView6.Columns.Count; k++)
                {
                    if (dataGridView6[k, i].Value != null)
                        p6.AddCell(new Phrase(dataGridView6[k, i].Value.ToString()));
                }
            }
            d.Add(p6);


            PdfPTable m14 = new PdfPTable(1);

            m14.AddCell(new PdfPCell() { HorizontalAlignment = PdfPCell.ALIGN_LEFT, Phrase = new Phrase("Karkardooma\n"), BorderColor = BaseColor.WHITE, BorderWidth = 0 });
            d.Add(m14);

            m.DefaultCell.HasBorder(iTextSharp.text.Rectangle.NO_BORDER);

            PdfPTable p7 = new PdfPTable(dataGridView7.Columns.Count);
            for (int j = 0; j < dataGridView7.Columns.Count; j++)
            {
                p7.AddCell(new Phrase(dataGridView7.Columns[j].HeaderText));
            }
            p7.HeaderRows = 1;
            for (int i = 0; i < dataGridView7.Rows.Count; i++)
            {
                for (int k = 0; k < dataGridView7.Columns.Count; k++)
                {
                    if (dataGridView7[k, i].Value != null)
                        p7.AddCell(new Phrase(dataGridView7[k, i].Value.ToString()));
                }
            }
            d.Add(p7);
            d.Close();
            wri.Close();
            SendToPrinter();

        }

        private void SendToPrinter()
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "open";
            info.FileName = @"test.pdf";
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process p = new Process();
            p.StartInfo = info;
            p.Start();

            p.WaitForInputIdle();
            System.Threading.Thread.Sleep(3000);
           
              
        }
        public bool PrintPDF(
    string printer,
    string paperName,
    string filename,
    int copies)
        {
            try
            {
                // Create the printer settings for our printer
                var printerSettings = new PrinterSettings
                {
                    PrinterName = printer,
                    Copies = (short)copies,
                };

                // Create our page settings for the paper size selected
                var pageSettings = new PageSettings(printerSettings)
                {
                    Margins = new Margins(0, 0, 0, 0),
                };
                foreach (PaperSize paperSize in printerSettings.PaperSizes)
                {
                    if (paperSize.PaperName == paperName)
                    {
                        pageSettings.PaperSize = paperSize;
                        break;
                    }
                }

                // Now print the PDF document
                using (var document = PdfiumViewer.PdfDocument.Load("test.pdf"))
                {
                    using (var printDocument = document.CreatePrintDocument())
                    {
                        printDocument.PrinterSettings = printerSettings;
                        printDocument.DefaultPageSettings = pageSettings;
                        printDocument.PrintController = new StandardPrintController();
                        printDocument.Print();
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        string GetDefaultPrinter()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                    return printer;
            }
            return string.Empty;
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            panel pu = new panel();
            pu.Show();
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
