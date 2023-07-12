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
    public partial class frmServiceAdd : Form
    {
        private string stringConnection = "data source = DESKTOP-VA6CQHR\\FITRIAI; database=Restaurant; User=sa; Password=123";
        private SqlConnection koneksi;

        public frmServiceAdd()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            txtKdLyn.Text = "";
            txtKdLyn.Enabled = false;
            tgl.Text = "";
            tgl.Enabled = false;
            cbIdWaiter();
            cbIdCust();
            cbxidWaiter.Text = "";
            cbxidWaiter.Enabled = false;
            cbxIdCust.Enabled = false;
            btnSave.Enabled = false;
            btnUpdate.Enabled = false;
            btnOpen.Enabled = false;
            btnDel.Enabled = false;
            btnClear.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtKdLyn.Enabled = true;
            tgl.Enabled = true;
            cbxidWaiter.Enabled = true;
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
            string KodeLyn = txtKdLyn.Text;
            DateTime Tgl = tgl.Value;
            string IdWaiter = cbxidWaiter.Text;
            string IdCust = cbxIdCust.Text;

            if (KodeLyn == "")
            {
                MessageBox.Show("Masukkan Kode Layanan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                koneksi.Open();
                string strs = "insert into dbo.Layanan (kode_layanan, tanggal_layanan, id_pelayan, id_customer)" + "values (@KL, @tgl, @IDP, @id)";
                SqlCommand cmd = new SqlCommand(strs, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("IDK", KodeLyn));
                cmd.Parameters.Add(new SqlParameter("tgl", Tgl));
                cmd.Parameters.Add(new SqlParameter("IDP", IdWaiter));
                cmd.Parameters.Add(new SqlParameter("id", IdCust));
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
            string str = "select * from dbo.Layanan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvService.DataSource = ds.Tables[0];
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
                string query = "DELETE FROM Layanan";

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
            string KodeLyn = txtKdLyn.Text;
            DateTime Tgl = tgl.Value;
            string IdWaiter = cbxidWaiter.Text;
            string IdCust = cbxIdCust.Text;

            try
            {
                string str = "UPDATE Layanan SET tanggal_layanan = @tgl, id_pelayan = @IDP, id_customer = @id WHERE kode_layanan = @KL";

                using (SqlConnection koneksi = new SqlConnection(stringConnection))
                {
                    koneksi.Open();

                    using (SqlCommand command = new SqlCommand(str, koneksi))
                    {
                        command.Parameters.AddWithValue("@tgl", tgl);
                        command.Parameters.AddWithValue("@IDP", IdWaiter);
                        command.Parameters.AddWithValue("@id", IdCust);
                        command.Parameters.AddWithValue("@KL", KodeLyn);

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

        private void cbIdWaiter()
        {
            koneksi.Open();
            string str = "select id_pelayan from dbo.Waiters where not EXISTS (select kode_layanan from dbo.Layanan where dbo.Layanan.kode_layanan = dbo.Layanan.kode_layanan)";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();

            cbxidWaiter.DisplayMember = "id_pelayan";
            cbxidWaiter.ValueMember = "IDP";
            cbxidWaiter.DataSource = ds.Tables[0];
        }

        private void cbIdCust()
        {
            koneksi.Open();
            string str = "select id_customer from dbo.Customer where not EXISTS (select kode_layanan from dbo.Layanan where dbo.Layanan.kode_layanan = dbo.Layanan.kode_layanan)";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();

            cbxIdCust.DisplayMember = "id_customer";
            cbxIdCust.ValueMember = "id";
            cbxIdCust.DataSource = ds.Tables[0];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
