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
    public partial class update1 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public update1()
        {
            InitializeComponent();
        }

        private void update1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=db4;Data Source=DESKTOP-TO1RL57");
            adp = new SqlDataAdapter("select DEPTNO from DEPTDATA", con);
            DataSet dataset = new DataSet();
            adp.Fill(dataset, "DEPT");
            comboBox1.DataSource = dataset.Tables["DEPT"];
            comboBox1.ValueMember = "DEPTNO";

        }

        private void btnextract_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from empdata where deptno=@d ",con);
            adp.SelectCommand.Parameters.AddWithValue("@d",int.Parse(textdeptno.Text));
            DataSet D = new DataSet();
            adp.Fill(D,"Emp");
            dataGridView1.DataSource = D.Tables["Emp"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=Demo;Data Source=DESKTOP-C983PNR");
            adp = new SqlDataAdapter("select * from DEPTDATA", con);
            DataSet dataset = new DataSet();
            adp.Fill(dataset, "dno");
            comboBox1.DataSource = dataset.Tables["dno"];
            comboBox1.ValueMember = "deptno";
            comboBox1.DisplayMember = "dname";


        }
    }
}
