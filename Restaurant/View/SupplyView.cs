﻿using Restaurant.Model;
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
    public partial class SupplyView : Form
    {
        public SupplyView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmSupplyAdd spl = new frmSupplyAdd();
            spl.Show();
        }

        private void btnbhn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
