using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class mu : Form
    {
        public mu()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminPage ad = new AdminPage();
            ad.Show();
            this.Hide();
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            CustomerPage cst = new CustomerPage();
            cst.Show();
            this.Hide();
        }
    }
}
