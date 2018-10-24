using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace merryscol
{
    public partial class FRM_PELANGGAN : Form
    {
        OracleConnection con = new OracleConnection("User ID=Merryscol;Password=merryscol#7;Data Source=XE");
        OracleCommand cmd;
        OracleDataAdapter adapt;
        OracleDataReader rd;

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new OracleDataAdapter("select * from pelanggan", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void otomatis()
        {
            long hitung;
            string urut;

            con.Open();
            cmd = new OracleCommand("select kode_pelanggan from pelanggan where kode_pelanggan in(select max(kode_pelanggan) from pelanggan) order by kode_pelanggan desc", con);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["kode_pelanggan"].ToString().Length - 4, 4)) + 1;

                string joinstr = "0000" + hitung;



                urut = "PLG" + joinstr.Substring(joinstr.Length - 4, 4);

            }
            else
            {
                urut = "PLG0001";
            }
            rd.Close();
            txt_kode_pelanggan.Text = urut;
            con.Close();

        }

        private void cleartext()
        {
            txt_kode_pelanggan.Text = "";
            txt_nama_pelanggan.Text = "";
            txt_telp_pelanggan.Text = "";
            txt_alamat_pelanggan.Text = "";
            txt_kode_pelanggan.Enabled = false;
        }

        public FRM_PELANGGAN()
        {
            InitializeComponent();
            cleartext();
            DisplayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            otomatis();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_kode_pelanggan.Text != "" && txt_nama_pelanggan.Text != "" && txt_telp_pelanggan.Text != "" && txt_alamat_pelanggan.Text != "")
            {
                try
                {
                cmd = new OracleCommand("insert into pelanggan(kode_pelanggan,nama_pelanggan,telp_pelanggan,alamat_pelanggan) values('" + txt_kode_pelanggan.Text + "','" + txt_nama_pelanggan.Text + "','" + txt_telp_pelanggan.Text + "','" + txt_alamat_pelanggan.Text + "')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data berhasil disimpan");
                DisplayData();
                cleartext();
                }
                catch (Exception)
                {
                    MessageBox.Show("gagal simpan, kode pelanggan tidak boleh sama");
                }
            }
            else
            {
                MessageBox.Show("gagal simpan");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_kode_pelanggan.Text != "" && txt_nama_pelanggan.Text != "" && txt_telp_pelanggan.Text != "" && txt_alamat_pelanggan.Text != "")
            {
                cmd = new OracleCommand("update pelanggan set nama_pelanggan='" + txt_nama_pelanggan.Text + "',telp_pelanggan='" + txt_telp_pelanggan.Text + "',alamat_pelanggan='" + txt_alamat_pelanggan.Text + "' where kode_pelanggan='" + txt_kode_pelanggan.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data berhasil disimpan");
                DisplayData();
                cleartext();
            }
            else
            {
                MessageBox.Show("gagal simpan");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txt_kode_pelanggan.Text != "")
            {
                cmd = new OracleCommand("delete pelanggan where kode_pelanggan='" + txt_kode_pelanggan.Text + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("berhasil hapus");
                DisplayData();
                cleartext();
            }
            else
            {
                MessageBox.Show("gagal hapus");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode_pelanggan.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nama_pelanggan.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_telp_pelanggan.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_alamat_pelanggan.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_kode_pelanggan.Enabled = false;
        }
    }
}
