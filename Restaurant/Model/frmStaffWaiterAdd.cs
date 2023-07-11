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
    public partial class frmStaffWaiterAdd : Form
    {
        private string stringConnection = "data source = DESKTOP-VA6CQHR\\FITRIAI; database=Restaurant; User=sa; Password=123";
        private SqlConnection koneksi;

        public frmStaffWaiterAdd()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            txtIDWaiter.Text = "";
            txtIDWaiter.Enabled = false;
            txtnmWaiter.Text = "";
            txtnmWaiter.Enabled = false;
            txtnoTlponWa.Text = "";
            txtnoTlponWa.Enabled = false;
            cbxJKWa.Text = "";
            cbxJKWa.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnOpen.Enabled = false;
            btnDel.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIDWaiter.Enabled = true;
            txtnmWaiter.Enabled = true;
            txtnoTlponWa.Enabled = true;
            cbxJKWa.Enabled = true;
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
            string idWaiter = txtIDWaiter.Text;
            string namaWaiter = txtnmWaiter.Text;
            string noTlpon = txtnoTlponWa.Text;
            string JK = cbxJKWa.Text;

            if (idWaiter == "")
            {
                MessageBox.Show("Masukkan ID Waiter", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                koneksi.Open();
                string strs = "insert into dbo.Waiters (id_pelayan, nama_pelayan, JK, no_telpon)" + "values (@IDP, @NP, @jk, @tlpon)";
                SqlCommand cmd = new SqlCommand(strs, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("IDP", idWaiter));
                cmd.Parameters.Add(new SqlParameter("NP", namaWaiter));
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
            string str = "select * from dbo.Waiters";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvWaiters.DataSource = ds.Tables[0];
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
            string idWaiter = txtIDWaiter.Text;
            string namaWaiter = txtnmWaiter.Text;
            string noTlpon = txtnoTlponWa.Text;
            string JK = cbxJKWa.Text;

            try
            {
                string str = "UPDATE Waiters SET nama_pelayan = @NP, no_telpon = @tlpon, JK = @jk WHERE id_pelayan = @IDP";

                using (SqlConnection koneksi = new SqlConnection(stringConnection))
                {
                    koneksi.Open();

                    using (SqlCommand command = new SqlCommand(str, koneksi))
                    {
                        command.Parameters.AddWithValue("@NP", namaWaiter);
                        command.Parameters.AddWithValue("@tlpon", noTlpon);
                        command.Parameters.AddWithValue("@jk", JK);
                        command.Parameters.AddWithValue("@IDP", idWaiter);

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
