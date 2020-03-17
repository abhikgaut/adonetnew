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
    public partial class Extract : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public Extract()
        {
            InitializeComponent();
        }

        private void Extract_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=db4;Data Source=DESKTOP-TO1RL57");
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonGetData_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select * from empdata where deptno=@dn",con);
            cmd.Parameters.AddWithValue("@dn",int.Parse(textdept.Text));
            SqlDataReader R = cmd.ExecuteReader();
            DataSet D = new DataSet();
            D.Tables.Add("deptdata");
            D.Tables["deptdata"].Load(R);
            dgvData.DataSource = D.Tables["deptdata"];
            con.Close();
            
        }

        private void btndate_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("select * from empdata where hiredate between @s and @e", con);
            cmd.Parameters.AddWithValue("@s", DateTime.Parse(dateTimePicker1.Text));
            cmd.Parameters.AddWithValue("@e", DateTime.Parse(dateTimePicker2.Text));
            SqlDataReader R = cmd.ExecuteReader();
            DataSet D = new DataSet();
            D.Tables.Add("deptdata");
            D.Tables["deptdata"].Load(R);
            dgvData.DataSource = D.Tables["deptdata"];
            con.Close();
        }
    }
}
