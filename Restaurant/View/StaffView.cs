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
    public partial class StaffView : Form
    {
        public StaffView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StaffCatView scat = new StaffCatView();
            scat.Show();
        }

        private void btnStaffChef_Click(object sender, EventArgs e)
        {
            frmStaffChefAdd chef = new frmStaffChefAdd();
            chef.Show();
        }

        private void btnStafWaiter_Click(object sender, EventArgs e)
        {
            frmStaffWaiterAdd wa = new frmStaffWaiterAdd();
            wa.Show();
        }

        private void btnStaffCashier_Click(object sender, EventArgs e)
        {
            frmStaffCashierAdd cash = new frmStaffCashierAdd();
            cash.Show();
        }
    }
}
