using Restaurant.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class AdminPage : Form
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            AddControls(new DashboardView());
        }

        public void AddControls(Form f)
        {
            centerPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            centerPanel.Controls.Add(f);
            f.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            AddControls(new BhnBakuView());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            AddControls(new StaffView());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            AddControls(new ReportView());
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            AddControls(new SupplierView());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mu mu = new mu();
            mu.Show();
            this.Hide();
        }
    }
}
