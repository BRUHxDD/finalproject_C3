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

namespace Restaurant.Model
{
    public partial class frmStaffCashierAdd : Form
    {
        private string stringConnection = "data source = DESKTOP-VA6CQHR\\FITRIAI; database=Restaurant; User=sa; Password=123";
        private SqlConnection koneksi;

        public frmStaffCashierAdd()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            txtIdCash.Text = "";
            txtIdCash.Enabled = false;
            txtnmCashier.Text = "";
            txtnmCashier.Enabled = false;
            txtnoTlpon.Text = "";
            txtnoTlpon.Enabled = false;
            cbxJK.Text = "";
            cbxJK.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnOpen.Enabled = false;
            btnDel.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIdCash.Enabled = true;
            txtnmCashier.Enabled = true;
            txtnoTlpon.Enabled = true;
            cbxJK.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void frmStaffCatAdd_Load(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idCashier = txtIdCash.Text;
            string namaCashier = txtnmCashier.Text;
            string noTlpon = txtnoTlpon.Text;
            string JK = cbxJK.Text;

            if (idCashier == "")
            {
                MessageBox.Show("Masukkan ID Cashier", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                koneksi.Open();
                string strs = "insert into dbo.Kasir (id_kasir, nama_kasir, JK, no_telpon)" + "values (@IDK, @NK, @jk, @tlpon)";
                SqlCommand cmd = new SqlCommand(strs, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("IDK", idCashier));
                cmd.Parameters.Add(new SqlParameter("NK", namaCashier));
                cmd.Parameters.Add(new SqlParameter("tlpon", noTlpon));
                cmd.Parameters.Add(new SqlParameter("jk", JK));
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
            string str = "select * from dbo.Kasir";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvCashier.DataSource = ds.Tables[0];
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
                string query = "DELETE FROM Koki";

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
            string idCashier = txtIdCash.Text;
            string namaCashier = txtnmCashier.Text;
            string noTlpon = txtnoTlpon.Text;
            string JK = cbxJK.Text;

            try
            {
                string str = "UPDATE Kasir SET nama_kasir = @NK, no_telpon = @tlpon, JK = @jk WHERE id_kasir = @IDK";

                using (SqlConnection koneksi = new SqlConnection(stringConnection))
                {
                    koneksi.Open();

                    using (SqlCommand command = new SqlCommand(str, koneksi))
                    {
                        command.Parameters.AddWithValue("@NK", namaCashier);
                        command.Parameters.AddWithValue("@tlpon", noTlpon);
                        command.Parameters.AddWithValue("@jk", JK);
                        command.Parameters.AddWithValue("@IDK", idCashier);

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
