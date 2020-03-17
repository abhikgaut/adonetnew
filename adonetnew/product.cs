using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace adonetnew
{
    class check
    {
        SqlConnection Con = null;
        SqlCommand Cmd = null;
        int product_id;
        public check(int product_id)
        {
            this.product_id = product_id;
        }
        public int Product_id { get => product_id; }
        public void product()
        {
            try
            {
                Con = new SqlConnection("Password=Admin@123;Persist Security Info=True;User ID=sa;Initial Catalog=allnewdb;Data Source=DESKTOP-TO1RL57");
                Con.Open();
                Cmd = new SqlCommand("select product_id,product_name,description,standard_cost,list_price from productinfo where product_id=@pid", Con);
                Cmd.Parameters.AddWithValue("@pid", Product_id);
                SqlDataReader R = Cmd.ExecuteReader();
                R.Read();
                Console.WriteLine("PRODUCT_ID : " + R[0]);
                Console.WriteLine("PRODUCT_NAME : " + R[1]);
                Console.WriteLine("DESCRIPTION : " + R[2]);
                Console.WriteLine("STANDARD_COST : " + R[3]);
                Console.WriteLine("LIST_PRICE : " + R[4]);
            }
            catch (InvalidOperationException E)
            {
                Console.WriteLine(" Invalid Product_id");
            }
            finally
            {
                Con.Close();
            }
        }
    }
    class Adodotnet
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Product ID : ");
            int pid = int.Parse(Console.ReadLine());
            check Ch = new check(pid);
            Ch.product();
            Console.Read();
        }
    }
}
