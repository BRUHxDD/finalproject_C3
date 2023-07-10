using Restaurant.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.View
{
    public partial class StaffCatView : Form
    {
        public StaffCatView()
        {
            InitializeComponent();
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStaffChefAdd chef = new frmStaffChefAdd();
            chef.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmStaffWaiterAdd waiter = new frmStaffWaiterAdd();
            waiter.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmStaffCashierAdd cash = new frmStaffCashierAdd();
            cash.Show();
        }
    }
}
