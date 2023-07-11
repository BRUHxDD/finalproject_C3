using Restaurant.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant.View
{
    public partial class BhnBakuView : Form
    {
        private string stringConnection = "data source = DESKTOP-VA6CQHR\\FITRIAI; database=Restaurant; User=sa; Password=123";
        private SqlConnection koneksi;
        private string KodeBhn, namaBhn, KodeSupp, Jumlah, IdSupp;
        private decimal TBayar;
        private DateTime tgl;
        private NumericUpDown stock;

        public BhnBakuView()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void refreshform()
        {
            txtKDBhn.Text = "";
            txtKDBhn.Enabled = false;
            txtnmBhn.Text = "";
            txtnmBhn.Enabled = false;
            txtKdSupp.Text = "";
            txtKdSupp.Enabled = false;
            txtJmlh.Text = "";
            txtJmlh.Enabled = false;
            txtTByr.Text = "";
            txtTByr.Enabled = false;
            btnSave.Enabled = false;
            btnSave1.Enabled = false;
            btnUpdate.Enabled = false;
            btnUpdate1.Enabled = false;
            btnOpen.Enabled = true;
            btnOpen1.Enabled = true;
            btnDel.Enabled = false;
            btnDel1.Enabled = false;
            btnClear.Enabled = false;
            btnClear1.Enabled = false;
            nmrcStk.Enabled = false;
            tglSupp.Enabled = false;
            id_Spl.Visible = false;
            kd_Bahan.Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtKDBhn.Enabled = true;
            txtnmBhn.Enabled = true;
            nmrcStk.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnUpdate.Enabled = true;
            btnAdd1.Enabled = false;
            btnSave1.Enabled = false;
            btnClear1.Enabled = false;
            btnUpdate1.Enabled = false;
            btnOpen1.Enabled = true;
            txtKdSupp.Text = "";
            txtKdSupp.Enabled = false;
            txtJmlh.Text = "";
            txtJmlh.Enabled = false;
            txtTByr.Text = "";
            txtTByr.Enabled = false;
            tglSupp.Enabled = false;
            id_Spl.Visible = false;
            kd_Bahan.Visible = false;
        }

        private void BhnBakuView_Load(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            KodeBhn = txtKDBhn.Text;
            namaBhn = txtnmBhn.Text;
            int stock = (int)nmrcStk.Value;
            nmrcStk.Minimum = 0;
            

            if (KodeBhn == "")
            {
                MessageBox.Show("Masukkan Kode Bahan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                koneksi.Open();
                string strs = "insert into dbo.Bahan_bahan (kode_bahan, nama_bahan, stock)" + "values (@KD, @Nm, @stck)";
                SqlCommand cmd = new SqlCommand(strs, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("KD", KodeBhn));
                cmd.Parameters.Add(new SqlParameter("Nm", namaBhn));
                cmd.Parameters.Add(new SqlParameter("stck", stock));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }

            btnOpen.Enabled = true;
            btnDel.Enabled = true;
            btnAdd1.Enabled = true;
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select * from dbo.Bahan_bahan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvIng.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void dataGridView1()
        {
            koneksi.Open();
            string str = "select * from dbo.Supply";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvSupply.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = true;
        }

        private void btnClear1_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnDel1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Supply";

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

        private void btnUpdate1_Click(object sender, EventArgs e)
        {

            KodeBhn = kd_Bahan.Text;
            IdSupp = id_Spl.Text;
            KodeSupp = txtKdSupp.Text;
            Jumlah = txtJmlh.Text;
            tgl = tglSupp.Value;
            decimal.TryParse(txtTByr.Text, out TBayar);

            try
            {
                string str = "UPDATE Supplier SET kode_bahan = @kd, id_supplier = @id, tgl_supply = @tgl, jumlah_supply = @jmlh, total_byr = @byr  WHERE kode_supply = @kds";

                using (SqlConnection koneksi = new SqlConnection(stringConnection))
                {
                    koneksi.Open();

                    using (SqlCommand command = new SqlCommand(str, koneksi))
                    {
                        command.Parameters.AddWithValue("@kds", KodeSupp);
                        command.Parameters.AddWithValue("@kd", KodeBhn);
                        command.Parameters.AddWithValue("@id", IdSupp);
                        command.Parameters.AddWithValue("@tgl", tgl);
                        command.Parameters.AddWithValue("@jmlh", Jumlah);
                        command.Parameters.AddWithValue("@byr", TBayar);

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

        private void nmrcStk_ValueChanged(object sender, EventArgs e)
        {
            int stock = (int)nmrcStk.Value;
            nmrcStk.Minimum = 0;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "DELETE FROM Bahan_bahan";

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

        private void txtTByr_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbnmBhn()
        {
            koneksi.Open();
            string str = "select nama_bahan from dbo.Bahan_bahan where not EXISTS (select kode_supply from dbo.Supply where dbo.Supply.kode_bahan = dbo.Supply.kode_bahan)";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();

            cbxnmBhn.DisplayMember = "nama_bahan";
            cbxnmBhn.ValueMember = "kd";
            cbxnmBhn.DataSource = ds.Tables[0];
        }

        private void cbxnmBhn_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string KodeBhn = "";
            string strs = "select kode_bahan from dbo.Bahan_bahan where nama_bahan = @Nm";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@Nm", cbxnmBhn.Text));
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                KodeBhn = dr["kode_bahan"].ToString();
            }
            dr.Close();
            koneksi.Close();

            kd_Bahan.Text = KodeBhn;
        }

        private void cbnmSup()
        {
            koneksi.Open();
            string str = "select nama_supplier from dbo.Supplier where not EXISTS (select kode_supply from dbo.Supply where dbo.Supply.id_supplier = dbo.Supply.id_supplier)";

            SqlCommand cmd = new SqlCommand(str, koneksi);
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteReader();
            koneksi.Close();

            cbxnmSup.DisplayMember = "nama_supplier";
            cbxnmSup.ValueMember = "id";
            cbxnmSup.DataSource = ds.Tables[0];
        }

        private void cbxnmSup_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string IdSup = "";
            string strs = "select id_supplier from dbo.Supplier where nama_supplier = @Nm";
            SqlCommand cm = new SqlCommand(strs, koneksi);
            cm.CommandType = CommandType.Text;
            cm.Parameters.Add(new SqlParameter("@Nm", cbxnmSup.Text));
            SqlDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                IdSup = dr["id_supplier"].ToString();
            }
            dr.Close();
            koneksi.Close();

            id_Spl.Text = IdSup;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            KodeBhn = txtKDBhn.Text;
            namaBhn = txtnmBhn.Text;
            int stock = (int)nmrcStk.Value;
            nmrcStk.Minimum = 0;

            try
            {
                string str = "UPDATE Supplier SET nama_bahan = @Nm, stock = @stck WHERE kode_bahan = @kd";

                using (SqlConnection koneksi = new SqlConnection(stringConnection))
                {
                    koneksi.Open();

                    using (SqlCommand command = new SqlCommand(str, koneksi))
                    {
                        command.Parameters.AddWithValue("@kd", KodeBhn);
                        command.Parameters.AddWithValue("@Nm", namaBhn);
                        command.Parameters.AddWithValue("@stck", stock);

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

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            txtKdSupp.Enabled = true;
            txtJmlh.Enabled = true;
            txtTByr.Enabled = true;
            btnSave1.Enabled = true;
            btnClear1.Enabled = true;
            btnUpdate1.Enabled = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = false;
            btnClear.Enabled = false;
            btnUpdate.Enabled = false;
            txtKDBhn.Text = "";
            txtKDBhn.Enabled = false;
            txtnmBhn.Text = "";
            txtnmBhn.Enabled = false;
            tglSupp.Enabled = true;
            id_Spl.Visible = true;
            kd_Bahan.Visible = true;
            cbnmBhn();
            cbnmSup();
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            
            KodeBhn = kd_Bahan.Text;
            IdSupp = id_Spl.Text;
            KodeSupp = txtKdSupp.Text;
            Jumlah = txtJmlh.Text;
            tgl = tglSupp.Value;
            decimal.TryParse(txtTByr.Text, out TBayar);


            if (KodeSupp == "")
            {
                MessageBox.Show("Masukkan Kode Supplier", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                koneksi.Open();
                string strs = "insert into dbo.Supply (kode_supply, kode_bahan, id_supplier, tgl_supply, jumlah_supply, total_byr)" + "values (@kds, @KD, @id, @tgl, @jmlh, @byr)";
                SqlCommand cmd = new SqlCommand(strs, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("kds", KodeSupp));
                cmd.Parameters.Add(new SqlParameter("KD", KodeBhn));
                cmd.Parameters.Add(new SqlParameter("id", IdSupp));
                cmd.Parameters.Add(new SqlParameter("tgl", tgl));
                cmd.Parameters.Add(new SqlParameter("jmlh", Jumlah));
                cmd.Parameters.Add(new SqlParameter("byr", TBayar));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1();
                refreshform();
            }

            btnOpen1.Enabled = true;
            btnDel1.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }


    }
}
