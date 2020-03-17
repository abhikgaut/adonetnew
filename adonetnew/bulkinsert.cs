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


namespace adonetnew
{
    public partial class bulkinsert : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        DataSet d = null;
        public bulkinsert()
        {
            InitializeComponent();
        }

        private void bulkinsert_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=DB5;Data Source=DESKTOP-TO1RL57");
            panel1.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void discount_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select count(*) from orderdetails", con);
            d = new DataSet();
            adp.Fill(d,"c");
            orderId.Text =(int.Parse(d.Tables["c"].Rows[0][0].ToString())+1).ToString();
            adp = new SqlDataAdapter("select salesmanId,salesmanName from salesmandetails",con);
            adp.Fill(d, "s");
            salesId.DataSource = d.Tables["s"];
            salesId.DisplayMember = "salesmanName";
            salesId.ValueMember = "salesmanId";
            adp = new SqlDataAdapter("select customerId,customerName from customerdetails", con);
            adp.Fill(d, "cust");
            custId.DataSource = d.Tables["cust"];
            custId.DisplayMember = "customerName";
            custId.ValueMember = "customerId";
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_orderProducts",con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@oid",int.Parse(orderId.Text));
            adp.SelectCommand.Parameters.AddWithValue("@orderDesc", orderDesc.Text);
            adp.SelectCommand.Parameters.AddWithValue("@orderDate",DateTime.Parse(orderDate.Text));
            adp.SelectCommand.Parameters.AddWithValue("@discount",int.Parse(orderDisc.Text));
            adp.SelectCommand.Parameters.AddWithValue("@custId", custId.SelectedValue);
            adp.SelectCommand.Parameters.AddWithValue("@salesId", salesId.SelectedValue);
            DataTable MyTable = new DataTable();
            MyTable.Columns.Add("orderid",typeof(string));
            MyTable.Columns.Add("productid",typeof(string));
            MyTable.Columns.Add("qty",typeof(Int32));
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                MyTable.Rows.Add(orderId.Text, dataGridView1.Rows[i].Cells[0].Value.ToString(), dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            SqlParameter P = new SqlParameter("@ord_prod", MyTable);
            P.SqlDbType = SqlDbType.Structured;
            adp.SelectCommand.Parameters.Add(P);
            d = new DataSet();
            adp.Fill(d);
            MessageBox.Show("order placed");
            panel1.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(0))
            {
                adp = new SqlDataAdapter("select productid from productdetails",con);
                d = new DataSet();
                adp.Fill(d,"pid");
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    (row.Cells[0] as DataGridViewComboBoxCell).DataSource = d.Tables["pid"];
                    (row.Cells[0] as DataGridViewComboBoxCell).DisplayMember = "productid";
                }
            }
        }

        //private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (!dataGridView1.CurrentCell.ColumnIndex.Equals(0))
        //    {
        //        adp = new SqlDataAdapter("select * from productdetails where productid=@p", con);
        //        adp.SelectCommand.Parameters.AddWithValue("@p", dataGridView1.CurrentRow.Cells[0].Value);
        //        d = new DataSet();
        //        adp.Fill(d, "p");
        //        dataGridView1.CurrentRow.Cells[1].Value = d.Tables["p"].Rows[0][1];
        //        dataGridView1.CurrentRow.Cells[3].Value = d.Tables["p"].Rows[0][2];
        //    }
        //}

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[0].Value!=null)
            {
                if (!dataGridView1.CurrentCell.ColumnIndex.Equals(0))
                {
                    adp = new SqlDataAdapter("select * from productdetails where productid=@p", con);
                    adp.SelectCommand.Parameters.AddWithValue("@p", dataGridView1.CurrentRow.Cells[0].Value);
                    d = new DataSet();
                    adp.Fill(d, "p");
                    dataGridView1.CurrentRow.Cells[1].Value = d.Tables["p"].Rows[0][1];
                    dataGridView1.CurrentRow.Cells[3].Value = d.Tables["p"].Rows[0][2];
                }
            }
        }

        private void dataGridView1_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[2].Value != null)
            {
                int Q = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                int P = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                dataGridView1.CurrentRow.Cells[4].Value = Q * P;
            }
        }
    }
}
