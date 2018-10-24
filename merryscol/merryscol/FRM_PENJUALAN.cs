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
    public partial class FRM_PENJUALAN : Form
    {
        OracleConnection con = new OracleConnection("User ID=Merryscol;Password=merryscol#7;Data Source=XE");
        OracleCommand cmd;
        OracleDataAdapter adapt;
        OracleDataReader rd;

        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new OracleDataAdapter("select * from penjualan", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void DisplayDataPelanggan()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new OracleDataAdapter("select * from pelanggan", con);
            adapt.Fill(dt);
            dg_pelanggan.DataSource = dt;
            con.Close();
        }

        private void DisplayDataBarang()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new OracleDataAdapter("select * from barang", con);
            adapt.Fill(dt);
            dg_barang.DataSource = dt;
            con.Close();
        }

        private void otomatis()
        {
            long hitung;
            string urut;

            con.Open();
            cmd = new OracleCommand("select no_penjualan from penjualan_detail where no_penjualan in(select max(no_penjualan) from penjualan_detail) order by no_penjualan desc", con);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                hitung = Convert.ToInt64(rd[0].ToString().Substring(rd["no_penjualan"].ToString().Length - 4, 4)) + 1;

                string joinstr = "0000" + hitung;



                urut = "PNJ" + joinstr.Substring(joinstr.Length - 4, 4);

            }
            else
            {
                urut = "PNJ0001";
            }
            rd.Close();
            txt_no_penjualan.Text = urut;
            con.Close();
        }

        private void cleartext()
        {
            txt_kode_pelanggan.Text = "";
            txt_nama_pelanggan.Text = "";
            txt_no_telp.Text = "";
            txt_alamat.Text = "";
            txt_kode_barang.Text = "";
            txt_nama_barang.Text = "";
            txt_style.Text = "";
            txt_warna.Text = "";
            txt_satuan.Text = "";
            txt_harga.Text = "0";
            txt_stock.Text = "0";
            dateTimePicker2.Text = "";
            txt_jumlah_beli.Text = "";
            txt_sub_total.Text = "";
            txt_keterangan.Text = "";
            txt_no_penjualan.Enabled = false;
            txt_kode_pelanggan.Enabled = false;
            txt_kode_barang.Enabled = false;
            txt_stock.Enabled = false;
            txt_sub_total.Enabled = false;
        }

        public FRM_PENJUALAN()
        {
            InitializeComponent();
            DisplayData();
            DisplayDataPelanggan();
            DisplayDataBarang();
            cleartext();
        }

        private void FRM_PENJUALAN_Load(object sender, EventArgs e)
        {

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.Enabled = false;
            txt_no_penjualan.Enabled = false;
            cleartext();
            otomatis();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            cmd = new OracleCommand("insert into penjualan_detail select * from penjualan where no_penjualan='" + txt_no_penjualan.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Berhasil simpan");
            cmd = new OracleCommand("delete penjualan", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            DisplayData();
            cleartext();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_print_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int stock, jumlah_beli, stock_akhir;
            stock = int.Parse(txt_stock.Text);
            jumlah_beli = int.Parse(txt_jumlah_beli.Text);
            stock_akhir = stock - jumlah_beli;

            if (int.Parse(txt_stock.Text) >= int.Parse(txt_jumlah_beli.Text))
            {

                if (txt_no_penjualan.Text != "" && txt_kode_barang.Text != "" && txt_kode_pelanggan.Text != "" && txt_jumlah_beli.Text != "" && txt_sub_total.Text != "" && txt_keterangan.Text != "")
                {
                    cmd = new OracleCommand("update barang set stock='" + stock_akhir + "' where kode_barang='" + txt_kode_barang.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("gagal simpan");
                }

                if (txt_no_penjualan.Text != "" && txt_kode_barang.Text != "" && txt_kode_pelanggan.Text != "" && txt_jumlah_beli.Text != "" && txt_sub_total.Text != "" && txt_keterangan.Text != "")
                {
                    try
                    {
                    cmd = new OracleCommand("insert into penjualan(no_penjualan,kode_barang,kode_pelanggan,jumlah_beli,tgl_penjualan,tgl_penerimaan,subtotal,keterangan) values('" + txt_no_penjualan.Text + "','" + txt_kode_barang.Text + "','" + txt_kode_pelanggan.Text + "','" + txt_jumlah_beli.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + dateTimePicker2.Value.ToShortDateString() + "','" + txt_sub_total.Text + "','" + txt_keterangan.Text + "')", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data berhasil disimpan");
                    DisplayData();
                    cleartext();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("gagal simpan, kode barang tidak boleh sama");
                    }
                }
                else
                {
                    MessageBox.Show("gagal simpan");
                }
            }
            else
            {
                MessageBox.Show("stock kurang");
            }
                
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (txt_nama_barang.Text != "")
            {
                cmd = new OracleCommand("delete penjualan where no_penjualan='" + txt_no_penjualan.Text + "' and kode_pelanggan='" + txt_kode_pelanggan.Text + "' and kode_barang='" + txt_kode_barang.Text + "'", con);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_no_penjualan.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            dg_pelanggan_CellContentClick(sender, e);
            dg_barang_CellContentClick(sender, e);
            txt_kode_pelanggan.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_kode_barang.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_jumlah_beli.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_sub_total.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_keterangan.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            DisplayData();
        }

        private void dg_pelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode_pelanggan.Text = dg_pelanggan.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nama_pelanggan.Text = dg_pelanggan.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_no_telp.Text = dg_pelanggan.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_alamat.Text = dg_pelanggan.Rows[e.RowIndex].Cells[3].Value.ToString();
            group_cari_pelanggan.Visible = false;
        }

        private void dg_barang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode_barang.Text = dg_barang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nama_barang.Text = dg_barang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_style.Text = dg_barang.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_warna.Text = dg_barang.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_satuan.Text = dg_barang.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_harga.Text = dg_barang.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_stock.Text = dg_barang.Rows[e.RowIndex].Cells[6].Value.ToString();
            group_cari_barang.Visible = false;
        }

        private void pilih_pelanggan_Click(object sender, EventArgs e)
        {
            group_cari_pelanggan.Visible = true;
        }

        private void pilih_barang_Click(object sender, EventArgs e)
        {
            group_cari_barang.Visible = true;
        }

        private void txt_jumlah_beli_TextChanged(object sender, EventArgs e)
        {
            if (txt_jumlah_beli.Text != "") txt_sub_total.Text = (int.Parse(txt_harga.Text) * int.Parse(txt_jumlah_beli.Text)).ToString();
            else txt_sub_total.Text = "0";
        }
    }
}
