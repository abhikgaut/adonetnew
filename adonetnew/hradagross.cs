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
    public partial class hradagross : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public hradagross()
        {
            InitializeComponent();
        }

        private void hradagross_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=db4;Data Source=DESKTOP-TO1RL57");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("dates",con);
            //adp.SelectCommand.Parameters.AddWithValue("@dno", textdept.SelectedValue);
            DataSet D = new DataSet();
            adp.Fill(D, "E");
            dataGridView1.DataSource = D.Tables["E"];
        }
    }
}
