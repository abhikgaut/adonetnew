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
    public partial class trg_del : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public trg_del()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trg_del_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=triggers;Data Source=DESKTOP-TO1RL57");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_deldel", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@empno",int.Parse(textdel.Text));
            SqlParameter P = new SqlParameter("@status", SqlDbType.NVarChar,200);
            P.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(P);
            DataSet d = new DataSet();
            adp.Fill(d);
            MessageBox.Show(P.Value.ToString());

        }
    }
}
