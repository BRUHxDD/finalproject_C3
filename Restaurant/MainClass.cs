using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    class MainClass
    {

        public static readonly string stringConnection = "data source = DESKTOP-VA6CQHR\\FITRIAI; database=Restaurant; User=sa; Password=123";
        public static SqlConnection koneksi = new SqlConnection(stringConnection);


        public static int SQl(string str, Hashtable ht)
        {
            int res = 0;

            try
            {

                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht)
                {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                    
                }
                if (koneksi.State == ConnectionState.Closed) { koneksi.Open(); }
                
                if (koneksi.State == ConnectionState.Open) { koneksi.Close(); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                koneksi.Close();
            }

            return res;
        }

        //Loading Database
        public static void LoadData(string str, DataGridView gdv, ListBox lb)
        {

            try
            {

                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++)
                {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gdv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();
                }

                gdv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                koneksi.Close();
            }
        }
    }
}
