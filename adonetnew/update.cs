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
    public partial class update : Form
    {
        SqlConnection con = null;
        SqlCommand cmd = null;
        public update()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void update_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=adoDB;Data Source=DESKTOP-TO1RL57");

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update employe set ename=@En,deptno=@dn where empno=@Eno", con);
                cmd.Parameters.AddWithValue("@En", txtname.Text);
                cmd.Parameters.AddWithValue("@dn", int.Parse(textdept.Text));
                cmd.Parameters.AddWithValue("@Eno", int.Parse(txtempno.Text));
                int m = cmd.ExecuteNonQuery();
                MessageBox.Show(m + "rows updated");
            }
            catch (SqlException E)
            {
                MessageBox.Show("ename must be given within 12 char");
            }
            catch (FormatException E)
            {
                MessageBox.Show("please enter details");
            }
            catch (InvalidOperationException E)
            {
                MessageBox.Show("some error broooo");
            }
            finally { con.Close(); }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("Select * from employe where empno=@Eno", con);
                cmd.Parameters.AddWithValue("@Eno", int.Parse(txtempno.Text));
                SqlDataReader R = cmd.ExecuteReader();//select command
                R.Read();
                txtname.Text = R[1].ToString();
                txtgender.Text = R[2].ToString();
                txtdate.Text = R[3].ToString();
                textdept.Text = R[4].ToString();
                
            }
            catch (InvalidOperationException E)
            {
                MessageBox.Show("no employee with number");
            }
            catch(FormatException E)
            {
                MessageBox.Show("only number ");
            }
            finally
            {
                con.Close();
            }
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("delete from employe where empno=@Eno", con);
                cmd.Parameters.AddWithValue("@Eno", int.Parse(txtempno.Text));
                int m = cmd.ExecuteNonQuery();
                if (m != 0)
                    MessageBox.Show(m + "rows deleted");
                else
                    MessageBox.Show("no employee exist bro");
              
            }
            catch (InvalidOperationException E)
            {
                MessageBox.Show("no employee with number");
                txtname.Text = "";
                textdept.Text = "";
                txtgender.Text = "";
                txtdate.Text = "";
            }
            catch (FormatException E)
            {
                MessageBox.Show("only number ");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
