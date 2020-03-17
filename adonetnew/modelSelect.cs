using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace adonetnew
{
    public partial class modelSelect : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet d = null;
        public modelSelect()
        {
            InitializeComponent();
        }

        private void modelSelect_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=DB5;Data Source=DESKTOP-TO1RL57");
            adp = new SqlDataAdapter("select * from productdetails", con);
            d = new DataSet();
            adp.Fill(d, "p");
            dataGridView1.DataSource = d.Tables["p"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int total = 0;
            FileStream f = new FileStream("C:/Users/Admin/Desktop/844441/result1.pdf", FileMode.Create);
            Document doc = new Document();
            PdfWriter.GetInstance(doc, f);
            doc.Open();
            Chunk chk = new Chunk("PRODUCT DETAILS\n\n",FontFactory.GetFont("agencyfb"));
            chk.Font.Color = new iTextSharp.text.BaseColor(51, 51, 255);
            chk.Font.SetStyle(2);
            chk.Font.Size = 20;
            Paragraph p = new Paragraph(chk);
            p.Alignment = Element.ALIGN_CENTER;
            doc.Add(p);
            PdfPTable table = new PdfPTable(3);
            PdfPCell cell = new PdfPCell();
            cell.Colspan = 2;
            cell.VerticalAlignment = 1;
            table.AddCell("product id");
            table.AddCell("product description");
            table.AddCell("price");

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    if ((bool)(dataGridView1.Rows[i].Cells[0] as DataGridViewCheckBoxCell).Value == true)
                    {
                        string pid = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        string pdesc = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        string pc = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        table.AddCell(pid);
                        table.AddCell(pdesc);
                        table.AddCell(pc);
                        //table.Alignment = Element.ALIGN_CENTER;
                        details dt = new details(pid, pdesc, pc);
                        total = total +int.Parse(pc);
                        dt.Show();
                    }
                }
            }
            table.AddCell("");
            table.AddCell("amount");
            table.AddCell(total.ToString());
            doc.Add(table);
            doc.Close();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int rindex = e.RowIndex;
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    if (rindex != i)
            //    {
            //        dataGridView1.Rows[i].Cells["select"].Value = false;
            //    }
            //}
        }
    }
}
