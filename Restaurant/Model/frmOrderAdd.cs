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
    public partial class frmOrderAdd : Form
    {
        private string stringConnection = "data source = DESKTOP-VA6CQHR\\FITRIAI; database=Restaurant; User=sa; Password=123";
        private SqlConnection koneksi;
        private string IdOrder, Menu, IdChef, IdCustomer;
        private decimal Harga;
        private NumericUpDown Jumlah;

        public frmOrderAdd()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            txtIdOrder.Text = "";
            txtIdOrder.Enabled = false;
            txtMenu.Text = "";
            txtMenu.Enabled = false;
            txtHarga.Text = "";
            txtHarga.Enabled = false;
            jmlh.Enabled = false;
            cbIdChef();
            cbxidChef.Enabled = false;
            cbIdCust();
            cbxIdCust.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnOpen.Enabled = false;
            btnDel.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtIdOrder.Enabled = true;
            txtMenu.Enabled = true;
            txtHarga.Enabled = true;
            cbxidChef.Enabled = true;
            cbxIdCust.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void frmServiceAdd_Load(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IdOrder = txtIdOrder.Text;
            Menu = txtMenu.Text;
            IdChef = cbxidChef.Text;
            IdCustomer = cbxIdCust.Text;
            decimal.TryParse(txtHarga.Text, out Harga);
            int Jumlah = (int)jmlh.Value;
            jmlh.Minimum = 0;

            if (IdOrder == "")
            {
                MessageBox.Show("Masukkan ID Pesanan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                koneksi.Open();
                string strs = "insert into dbo.Pesanan (id_pesanan, menu, jumlah_pesanan, harga, id_koki, id_koki)" + "values (@id, @menu, @jmlh, @hrg, @IDK, @IDC)";
                SqlCommand cmd = new SqlCommand(strs, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("id", IdOrder));
                cmd.Parameters.Add(new SqlParameter("menu", Menu));
                cmd.Parameters.Add(new SqlParameter("jmlh", Jumlah));
                cmd.Parameters.Add(new SqlParameter("hrg", Harga));
                cmd.Parameters.Add(new SqlParameter("IDK", IdCustomer));
                cmd.Parameters.Add(new SqlParameter("IDC", IdChef));
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
            string str = "select * from dbo.Pesanan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvOrder.DataSource = ds.Tables[0];
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
                string query = "DELETE FROM Pesanan";

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
            IdOrder = txtIdOrder.Text;
            Menu = txtMenu.Text;
            IdChef = cbxidChef.Text;
            IdCustomer = cbxIdCust.Text;
            decimal.TryParse(txtHarga.Text, out Harga);
            int Jumlah = (int)jmlh.Value;
            jmlh.Minimum = 0;

            try
            {
                string str = "UPDATE Pesanan SET menu = @menu, jumlah_pesanan = @jmlh, harga = @hrg, id_koki = @IDC, id_customer = @IDK WHERE id_pesanan = @id";

                using (SqlConnection koneksi = new SqlConnection(stringConnection))
                {
                    koneksi.Open();

                    using (SqlCommand command = new SqlCommand(str, koneksi))
                    {
                        command.Parameters.AddWithValue("@menu", Menu);
                        command.Parameters.AddWithValue("@jmlh", Jumlah);
                        command.Parameters.AddWithValue("@hrg", Harga);
                        command.Parameters.AddWithValue("@IDK", IdCustomer);
                        command.Parameters.AddWithValue("@IDC", IdChef);
                        command.Parameters.AddWithValue("@id", IdOrder);

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

        private void cbIdChef()
        {
            koneksi.Open();
            string str = "select id_koki from dbo.Koki where not EXISTS (select id_pesanan from dbo.Pesanan where dbo.Pesanan.id_pesanan = dbo.Pesanan.id_pesanan)";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();

            cbxidChef.DisplayMember = "id_koki";
            cbxidChef.ValueMember = "IDC";
            cbxidChef.DataSource = ds.Tables[0];
        }

        private void cbIdCust()
        {
            koneksi.Open();
            string str = "select id_customer from dbo.Customer where not EXISTS (select id_pesanan from dbo.Pesanan where dbo.Pesanan.id_pesanan = dbo.Pesanan.id_pesanan)";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();

            cbxIdCust.DisplayMember = "id_customer";
            cbxIdCust.ValueMember = "idK";
            cbxIdCust.DataSource = ds.Tables[0];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
