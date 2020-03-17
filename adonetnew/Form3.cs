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
    public partial class Form3 : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=db4;Data Source=DESKTOP-TO1RL57");
            adp = new SqlDataAdapter("select * from EMPDATA", con);
            DataSet D = new DataSet();
            SqlCommandBuilder cmb = new SqlCommandBuilder(adp);
            SqlCommand cmd = cmb.GetDeleteCommand();
            MessageBox.Show(cmd.CommandText);

        }
    }
}
