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
    public partial class Form2 : Form
    {
        SqlConnection Con = null;
        SqlCommand Cmd = null;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //step 1
            Con = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=adoDB;Data Source=DESKTOP-TO1RL57");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                //step 2
                Con.Open();
                //step 3
                Cmd = new SqlCommand("insert into employe values(@Eno,@En,@g,@d)", Con);
                Cmd.Parameters.AddWithValue("@Eno", int.Parse(txtempno.Text));
                Cmd.Parameters.AddWithValue("@En", txtname.Text);
                Cmd.Parameters.AddWithValue("@g", txtgender.Text);
                Cmd.Parameters.AddWithValue("@d", DateTime.Parse(txtdate.Text));
                //step 4
                int R = Cmd.ExecuteNonQuery();
            }
            catch (SqlException E)
            {
                if (E.Message.Contains("PK_employe"))
                    MessageBox.Show("employee canot be duplicate");
                else if (E.Message.Contains("CK_dob"))
                 MessageBox.Show("minimum age 21");
                else if (E.Message.Contains("CK_gender"))
                  MessageBox.Show("minimum age 21");
            }
            
            //step 5
            finally
            { Con.Close(); }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtgender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
