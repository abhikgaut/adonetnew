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
    public partial class newnew : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public newnew()
        {
            InitializeComponent();
        }

        private void newnew_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=db4;Data Source=DESKTOP-TO1RL57");

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void texteno_Leave(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_extract",con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno",int.Parse(texteno.Text));
            DataSet D=new DataSet();
            adp.Fill(D,"E");
            DataRow R = null;

            if (D.Tables["E"].Rows.Count != 0)
            {
                R = D.Tables["E"].Rows[0];
                int.Parse(texteno.Text);
                textname.Text = R[1].ToString();
                textjob.Text = R[2].ToString();
                textmgr.Text = R[3].ToString();
                dateTimePicker1.Text = R[4].ToString();
                textsalary.Text = R[5].ToString();
                textcomm.Text = R[6].ToString();
                combodno.Text = R[7].ToString();
            }
            else
                MessageBox.Show("does not exist");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            adp = new SqlDataAdapter("new_procdure1", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(texteno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@newjob", textjob.Text);
         
            adp.SelectCommand.Parameters.AddWithValue("@incrper", float.Parse(textIncre.Text));
            SqlParameter s = new SqlParameter("@status", SqlDbType.NVarChar, 100);
            s.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(s);
            DataSet D = new DataSet();
            adp.Fill(D);
            MessageBox.Show(s.Value.ToString());
        }

        private void textjob_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
