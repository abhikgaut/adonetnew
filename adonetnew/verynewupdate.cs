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
    public partial class verynewupdate : Form
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        public verynewupdate()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void verynewupdate_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=adoDB;Data Source=DESKTOP-TO1RL57");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("new_procdure", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(txtempno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@en", txtname.Text);
            //adp.SelectCommand.Parameters.AddWithValue("@g", txtgender.Text);
            //adp.SelectCommand.Parameters.AddWithValue("@db", DateTime.Parse(txtdate.Text));
            adp.SelectCommand.Parameters.AddWithValue("@dno", int.Parse(textdept.Text));
            SqlParameter s = new SqlParameter("@result", SqlDbType.NVarChar, 100);
            s.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(s);
            DataSet D = new DataSet();
            adp.Fill(D);
            MessageBox.Show(s.Value.ToString());
        }
    }
}
