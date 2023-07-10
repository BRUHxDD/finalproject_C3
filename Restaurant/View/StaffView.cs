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
    }
}
