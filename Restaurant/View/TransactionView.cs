using Restaurant.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.View
{
    public partial class TransactionView : Form
    {
        private string stringConnection = "data source = DESKTOP-VA6CQHR\\FITRIAI; database=Restaurant; User=sa; Password=123";
        private SqlConnection koneksi;
        public TransactionView()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }
        private void refreshform()
        {
            txtIdTR.Text = "";
            txtIdTR.Enabled = false;
            txtJumlah.Text = "";
            txtJumlah.Enabled = false;
            tgl.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnOpen.Enabled = false;
            btnDel.Enabled = false;
            btnClear.Enabled = false;
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            txtIdTR.Enabled = true;
            txtJumlah.Enabled = true;
            tgl.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnUpdate.Enabled = true;
            btnOpen.Enabled = true;
            btnDel.Enabled = true;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = true;
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Transaksi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvTransaction.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Transaksi";

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
        private void btnSave_Click(object sender, EventArgs e)
        {
            string idTransaksi = txtIdTR.Text;
            string jumlahTransaksi = txtJumlah.Text;
            string tanggalTransaksi = tgl.Text;
            string metodePembayaran = cbxMByr.Text;

            if (idTransaksi == "")
            {
                MessageBox.Show("Masukkan ID Transaksi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                koneksi.Open();
                string strs = "insert into dbo.Customer (id_transaksi, jumlah_transaksi, tanggal_transaksi, metode_pembayaran)" + "values (@id, @jml, @tgl, @mtd)";
                SqlCommand cmd = new SqlCommand(strs, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id", idTransaksi));
                cmd.Parameters.Add(new SqlParameter("jml", jumlahTransaksi));
                cmd.Parameters.Add(new SqlParameter("tgl", tanggalTransaksi));
                cmd.Parameters.Add(new SqlParameter("mtd", metodePembayaran));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }

            btnOpen.Enabled = true;
            btnDel.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string idTransaksi = txtIdTR.Text;
            string jumlahTransaksi = txtJumlah.Text;
            string tanggalTransaksi = tgl.Text;
            string metodePembayaran = cbxMByr.Text;
            try
            {
                string str = "UPDATE Transaksi SET id_transaksi = @id, jumlah_transaksi = @jml, tanggal_transaksi = @tgl, metode_pembayaran = @mtd";

                using (SqlConnection koneksi = new SqlConnection(stringConnection))
                {
                    koneksi.Open();

                    using (SqlCommand command = new SqlCommand(str, koneksi))
                    {
                        command.Parameters.AddWithValue("@id", idTransaksi);
                        command.Parameters.AddWithValue("@jml", jumlahTransaksi);
                        command.Parameters.AddWithValue("@tgl", tanggalTransaksi);
                        command.Parameters.AddWithValue("@mtd", metodePembayaran);

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }
    }
}
