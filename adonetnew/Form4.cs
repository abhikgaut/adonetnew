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
    public partial class Form4 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=db4;Data Source=DESKTOP-TO1RL57");
            adp = new SqlDataAdapter("select * from deptdata",con);
            DataSet D = new DataSet();
            adp.Fill(D,"dt");
            combodno.DataSource = D.Tables["dt"];
            combodno.ValueMember = "deptno";
            combodno.DisplayMember ="dname";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textmgr_TextChanged(object sender, EventArgs e)
        {

        }

        private void combodno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                adp = new SqlDataAdapter("select * from empdata", con);
                DataSet D = new DataSet();
                adp.Fill(D, "E");
                DataRow R = D.Tables["E"].NewRow();
                R[0] = int.Parse(texteno.Text);
                R[1] = textname.Text;
                R[2] = textjob.Text;
                R[3] = int.Parse(textmgr.Text);
                R[4] = DateTime.Parse(dateTimePicker1.Text);
                R[5] = int.Parse(textsalary.Text);
                R[6] = int.Parse(textcomm.Text);
                R[7] = combodno.SelectedValue;
                D.Tables["E"].Rows.Add(R);
                SqlCommandBuilder cmb = new SqlCommandBuilder(adp);
                adp.InsertCommand = cmb.GetInsertCommand();
                adp.Update(D, "E");
                MessageBox.Show("1 row affected");
                clear();
            }
            catch (SqlException E)
            {
                MessageBox.Show(E.Message);
            }
        }
        private void clear()
        {
            texteno.Text = "";
            textname.Text = "";
            textjob.Text = "";
            textmgr.Text = "";
            dateTimePicker1.Text = "";
            textsalary.Text = "";
            textcomm.Text = "";
            combodno.Text = "";
        }
    }
}
