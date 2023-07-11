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
    public partial class CustomerView : Form
    {
        private string stringConnection = "data source = DESKTOP-VA6CQHR\\FITRIAI; database=Restaurant; User=sa; Password=123";
        private SqlConnection koneksi;
        public CustomerView()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }
        private void refreshform()
        {
            txtIDCust.Text = "";
            txtIDCust.Enabled = false;
            txtnmCust.Text = "";
            txtnmCust.Enabled = false;
            txtnoTlpnCust.Text = "";
            txtnoTlpnCust.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnOpen.Enabled = false;
            btnDel.Enabled = false;
            btnClear.Enabled = false;
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            txtIDCust.Enabled = true;
            txtnmCust.Enabled = true;
            txtnoTlpnCust.Enabled = true;
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
            string str = "select * from dbo.Customer";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvCustomer.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Customer";

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
            string idCustomer = txtIDCust.Text;
            string namaCustomer = txtnmCust.Text;
            string noTelpon = txtnoTlpnCust.Text;
            try
            {
                string str = "UPDATE Customer SET id_customer = @id, nama_customer = @Nm, no_telpon = @tlpon";

                using (SqlConnection koneksi = new SqlConnection(stringConnection))
                {
                    koneksi.Open();

                    using (SqlCommand command = new SqlCommand(str, koneksi))
                    {
                        command.Parameters.AddWithValue("@Nm", namaCustomer);
                        command.Parameters.AddWithValue("@tlpon", noTelpon);
                        command.Parameters.AddWithValue("@id", idCustomer);

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idCustomer = txtIDCust.Text;
            string namaCustomer = txtnmCust.Text;
            string noTelpon = txtnoTlpnCust.Text;

            if (idCustomer == "")
            {
                MessageBox.Show("Masukkan ID Customer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                koneksi.Open();
                string strs = "insert into dbo.Customer (id_customer, nama_customer, no_telpon)" + "values (@id, @Nm, @tlpon)";
                SqlCommand cmd = new SqlCommand(strs, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id", idCustomer));
                cmd.Parameters.Add(new SqlParameter("Nm", namaCustomer));
                cmd.Parameters.Add(new SqlParameter("tlpon", noTelpon));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }

            btnOpen.Enabled = true;
            btnDel.Enabled = true;

        }
    }
}
