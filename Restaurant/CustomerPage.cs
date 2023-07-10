using Restaurant.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class CustomerPage : Form
    {
        public CustomerPage()
        {
            InitializeComponent();
        }

        public void AddControls(Form f)
        {
            centerPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            centerPanel.Controls.Add(f);
            f.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AddControls(new DashboardView());
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            AddControls(new MenuView());
        }

        private void btnTrns_Click(object sender, EventArgs e)
        {
            AddControls(new TransactionView());
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            AddControls(new BillView());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            AddControls(new CustomerView());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mu mu = new mu();
            mu.Show();
            this.Hide();
        }
    }
}
