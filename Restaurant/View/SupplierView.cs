using Restaurant.Model;
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

namespace Restaurant
{
    public partial class SupplierView : Form
    {
        private string stringConnection = "data source = DESKTOP-VA6CQHR\\FITRIAI; database=Restaurant; User=sa; Password=123";
        private SqlConnection koneksi;

        public SupplierView()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            txtIDSup.Text = "";
            txtIDSup.Enabled = false;
            txtnmSup.Text = "";
            txtnmSup.Enabled = false;
            txtnoTlpnSup.Text = "";
            txtnoTlpnSup.Enabled = false;
            txtnmJLN.Text = "";
            txtnmJLN.Enabled = false;
            txtKota.Text = "";
            txtKota.Enabled = false;
            txtProvinsi.Text = "";
            txtProvinsi.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnOpen.Enabled = false;
            btnDel.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIDSup.Enabled = true;
            txtnmSup.Enabled = true;
            txtnmJLN.Enabled = true;
            txtnoTlpnSup.Enabled = true;
            txtKota.Enabled = true;
            txtProvinsi.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void SupplierView_Load(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idSupplier = txtIDSup.Text;
            string namaSupplier = txtnmSup.Text;
            string noTlpon = txtnoTlpnSup.Text;
            string JLN = txtnmJLN.Text;
            string Kota = txtKota.Text;
            string Prov = txtProvinsi.Text;

            if (idSupplier == "")
            {
                MessageBox.Show("Masukkan ID SUpplier", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                koneksi.Open();
                string strs = "insert into dbo.Supplier (id_supplier, nama_supplier, No_telpon, Nama_jln, Kota, Provinsi)" + "values (@id, @Nm, @tlpon, @jln, @kota, @prov)";
                SqlCommand cmd = new SqlCommand(strs, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id", idSupplier));
                cmd.Parameters.Add(new SqlParameter("Nm", namaSupplier));
                cmd.Parameters.Add(new SqlParameter("tlpon", noTlpon));
                cmd.Parameters.Add(new SqlParameter("jln", JLN));
                cmd.Parameters.Add(new SqlParameter("kota", Kota));
                cmd.Parameters.Add(new SqlParameter("prov", Prov));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }

            btnOpen.Enabled = true;
            btnDel.Enabled = true;

        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Supplier";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvSupplier.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Supplier";

                using (SqlCommand cmd = new SqlCommand(query, koneksi))
                {
                    if (koneksi.State == ConnectionState.Closed) { koneksi.Open(); }
                    cmd.ExecuteNonQuery();
                    if (koneksi.State == ConnectionState.Open) { koneksi.Close(); }
                }

                MessageBox.Show("Data berhasil dihapus");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                koneksi.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string idSupplier = txtIDSup.Text;
            string namaSupplier = txtnmSup.Text;
            string noTlpon = txtnoTlpnSup.Text;
            string JLN = txtnmJLN.Text;
            string Kota = txtKota.Text;
            string Prov = txtProvinsi.Text;
            try
            {
                string str = "UPDATE Supplier SET nama_supplier = @Nm, No_telpon = @tlpon, Nama_jln = @jln, Kota = @kota, Provinsi = @prov WHERE id_supplier = @id";

                using (SqlConnection koneksi = new SqlConnection(stringConnection))
                {
                    koneksi.Open();

                    using (SqlCommand command = new SqlCommand(str, koneksi))
                    {
                        command.Parameters.AddWithValue("@Nm", namaSupplier);
                        command.Parameters.AddWithValue("@tlpon", noTlpon);
                        command.Parameters.AddWithValue("@jln", JLN);
                        command.Parameters.AddWithValue("@kota", Kota);
                        command.Parameters.AddWithValue("@prov", Prov);
                        command.Parameters.AddWithValue("@id", idSupplier);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data berhasil diperbarui");
                        }
                        else
                        {
                            MessageBox.Show("Gagal memperbarui data");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void txtIDSup_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
