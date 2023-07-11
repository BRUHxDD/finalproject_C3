using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.Model
{
    public partial class frmSupplierAdd : Form
    {
        

        public frmSupplierAdd()
        {
            InitializeComponent();
            
        }

        private void frmSupplierAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string id_supplier = "";

        public void btnSave_Click(object sender, EventArgs e)
        {
            string str = "";

            if (id_supplier == "")
            {
                str = "INSERT INTO Supplier(id_supplier, nama_supplier, No_telpon, Nama_jln, Kota, Provinsi) VALUES(@id, @Nm, @tlpon, @jln, @kota, @prov)";
            }
            else
            {
                str = "UPDATE Supplier SET nama_supplier = @Nm, No_telpon = @tlpon, Nama_jln = @jln, Kota = @kota, Provinsi = @prov WHERE id_supplier = @id";
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", idSup.Text);
            ht.Add("@Nm", nmSup.Text);
            ht.Add("@tlpon", noTlpnSup.Text);
            ht.Add("@jln", nmJLN.Text);
            ht.Add("@kota", Kota.Text);
            ht.Add("@prov", Provinsi.Text);

            if (MainClass.SQl(str, ht) > 0)
            {
                MessageBox.Show("Data Berhasil Disimpan");
                idSup.Text = "";
                idSup.Focus();
                nmSup.Text = "";
                nmSup.Focus();
                noTlpnSup.Text = "";
                noTlpnSup.Focus();
                nmJLN.Text = "";
                nmJLN.Focus();
                Kota.Text = "";
                Kota.Focus();
                Provinsi.Text = "";
                Provinsi.Focus();
                
            }

        }
    }
}
