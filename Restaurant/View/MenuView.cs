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
    public partial class MenuView : Form
    {
        public MenuView()
        {
            InitializeComponent();
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            frmServiceAdd sr = new frmServiceAdd();
            sr.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmOrderAdd or = new frmOrderAdd();
            or.Show();
        }
    }
}
