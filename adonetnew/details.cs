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
    public partial class details : Form
    {
        
        public details(string pid,string pdesc,string price)
        {
            InitializeComponent();
            label4.Text = pid;
            label5.Text = pdesc;
            label6.Text = price;
        }

        private void details_Load(object sender, EventArgs e)
        {
            
        }
    }
}
