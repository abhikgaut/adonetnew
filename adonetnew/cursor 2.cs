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
    public partial class cursor_2 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public cursor_2()
        {
            InitializeComponent();
        }

        private void cursor_2_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=db4;Data Source=DESKTOP-TO1RL57");
            adp = new SqlDataAdapter("select distinct deptno from empdata", con);
            DataSet D = new DataSet();
            adp.Fill(D, "dt");
            textdept.DataSource = D.Tables["dt"];
            textdept.ValueMember = "deptno";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_cursorEx", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@dno", textdept.SelectedValue);
            //SqlParameter s = new SqlParameter("@status", SqlDbType.NVarChar, 50);
            //s.Direction = ParameterDirection.Output;
            //adp.SelectCommand.Parameters.Add(s);
            DataSet D = new DataSet();
            adp.Fill(D,"E");
            dataGridView1.DataSource = D.Tables["E"];
           // MessageBox.Show(s.Value.ToString());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
