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
 
    public partial class Form5 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=db4;Data Source=DESKTOP-TO1RL57");
            adp = new SqlDataAdapter("select * from deptdata", con);
            DataSet D = new DataSet();
            adp.Fill(D, "dt");
            combodno.DataSource = D.Tables["dt"];
            combodno.ValueMember = "deptno";
            combodno.DisplayMember = "deptno";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void texteno_Leave(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from empdata where empno=@E",con);
            adp.SelectCommand.Parameters.AddWithValue("@E",int.Parse(texteno.Text));
            DataSet D = new DataSet();
            adp.Fill(D, "E");
            //textname.Text = D.Tables["E"].Rows[0][1].ToString(); OR
            DataRow R = D.Tables["E"].Rows[0];
            textname.Text=R[1].ToString();
            textjob.Text=R[2].ToString();
            textmgr.Text=R[3].ToString();
            dateTimePicker1.Text=R[4].ToString();
            textsalary.Text=R[5].ToString();
            textcomm.Text=R[6].ToString();
            combodno.Text=R[7].ToString();
            


    }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("select * from empdata where empno=@E", con);
            adp.SelectCommand.Parameters.AddWithValue("@E", int.Parse(texteno.Text));
            DataSet D = new DataSet();
            adp.Fill(D, "E");
            DataRow R = D.Tables["E"].Rows[0];
            R[2] = textjob.Text;
            R[3] = int.Parse(textmgr.Text);
            R[5] = int.Parse(textsalary.Text);
            R[6] = int.Parse(textcomm.Text);
            R[7] = int.Parse(combodno.Text);
            SqlCommandBuilder cmb = new SqlCommandBuilder(adp);
            adp.UpdateCommand = cmb.GetUpdateCommand();
            adp.Update(D, "E");
            MessageBox.Show("1 row affected");

        }
    }
}
