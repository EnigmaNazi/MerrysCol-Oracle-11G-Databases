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
    public partial class PENJUALAN_METRO : Form
    {
        //koneksi database
        OracleConnection con = new OracleConnection("User ID=Merryscol;Password=merryscol#7;Data Source=XE");
        OracleCommand cmd;
        OracleDataAdapter adapt;
        OracleDataReader rd;

        //Display Data in DataGridView  
        private void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new OracleDataAdapter("select * from penjualan_metro", con);
            adapt.Fill(dt);
            dg_penjualan.DataSource = dt;
            con.Close();

        }
        private void DisplayDataBarang()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new OracleDataAdapter("select * from barang_metro", con);
            adapt.Fill(dt);
            dg_barang.DataSource = dt;
            con.Close();

        }

        private void DisplayDataPelanggan()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new OracleDataAdapter("select * from pelanggan_metro", con);
            adapt.Fill(dt);
            dg_pelanggan.DataSource = dt;
            con.Close();
        }
        private void otomatis()
        {
            long hitung;
            string urut;

            con.Open();

            cmd = new OracleCommand("select no_penjualan from penjualan_metro_detail where no_penjualan in(select max(no_penjualan) from penjualan_metro_detail) order by no_penjualan desc", con);
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

        //untuk clear text
        private void cleartext()
        {
            txt_kode_pelanggan.Text = "";
            txt_nama_pelanggan.Text = "";
            txt_notelp_pelanggan.Text = "";
            txt_alamat_pelanggan.Text = "";
            txt_kode_barang.Text = "";
            txt_nama_barang.Text = "";
            txt_satuan_barang.Text = "";
            txt_harga_barang.Text = "";
            txt_stock_barang.Text = "0";
            txt_jumlah_penjualan.Text = "";
            txt_terbilang.Text = "";
            txt_no_penjualan.Text = "";
            txt_sub_total.Text = "";
        }

        public PENJUALAN_METRO()
        {
            InitializeComponent();
            cleartext();
            DisplayData();
            DisplayDataBarang();
            DisplayDataPelanggan();
        }
        
        private void btn_new_penjualan_Click(object sender, EventArgs e)
        {
            dateTimePicker2.Value = DateTime.Today;
            dateTimePicker2.Enabled = false;
            txt_no_penjualan.Enabled = false;
            cleartext();
            otomatis();
        }

        private void btn_save_penjualan_Click(object sender, EventArgs e)
        {
            cmd = new OracleCommand("insert into penjualan_metro_detail select * from penjualan_metro where no_penjualan='" + txt_no_penjualan.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Berhasil simpan");
            cmd = new OracleCommand("delete penjualan_metro", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            DisplayData();
            cleartext();
        }

        private void btn_add_penjualan_Click(object sender, EventArgs e)
        {
            int stock, jumlah_beli, stock_akhir;
            stock = int.Parse(txt_stock_barang.Text);
            jumlah_beli = int.Parse(txt_jumlah_penjualan.Text);
            stock_akhir = stock - jumlah_beli;

            //pembatas pengurangan
            if (int.Parse(txt_stock_barang.Text) >= int.Parse(txt_jumlah_penjualan.Text))
            {
                if (txt_no_penjualan.Text != "" && txt_kode_barang.Text != "" && txt_kode_pelanggan.Text != "" && txt_jumlah_penjualan.Text != ""
                    && txt_sub_total.Text != "" && txt_terbilang.Text != "")
                {
                    cmd = new OracleCommand("update barang_metro set stock='" + stock_akhir + "' where kode_barang='" + txt_kode_barang.Text + "'", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("gagal simpan");
                }
                if (txt_no_penjualan.Text != "" && txt_kode_barang.Text != "" && txt_kode_pelanggan.Text != "" && txt_jumlah_penjualan.Text != ""
                     && txt_sub_total.Text != "" && txt_terbilang.Text != "")
                {
                    cmd = new OracleCommand("insert into penjualan_metro(no_penjualan,tgl_penjualan,kode_pelanggan,kode_barang,jumlah_beli,subtotal,terbilang,jenis_bayar) values('" + txt_no_penjualan.Text + "','" + dateTimePicker2.Value.ToShortDateString() + "','" + txt_kode_pelanggan.Text + "','" + txt_kode_barang.Text + "','" + txt_jumlah_penjualan.Text + "','" + txt_sub_total.Text + "','" + txt_terbilang.Text + "','" + txt_jenis_bayar.Text + "')", con);
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
            else
            {
                MessageBox.Show("stock kurang");
            }
        }

        private void btn_delete_penjualan_Click(object sender, EventArgs e)
        {
            if (txt_nama_barang.Text != "")
            {
                cmd = new OracleCommand("delete penjualan_metro where no_penjualan='" + txt_no_penjualan.Text + "' and kode_pelanggan='" + txt_kode_pelanggan.Text + "' and kode_barang='" + txt_kode_barang.Text + "'", con);
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

        private void btn_close_penjualan_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_pilih_pelanggan_Click(object sender, EventArgs e)
        {
            group_cari_pelanggan.Visible = true;
        }

        private void btn_pilih_barang_Click(object sender, EventArgs e)
        {
            group_cari_barang.Visible = true;
        }

        private void dg_pelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode_pelanggan.Text = dg_pelanggan.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nama_pelanggan.Text = dg_pelanggan.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_notelp_pelanggan.Text = dg_pelanggan.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_alamat_pelanggan.Text = dg_pelanggan.Rows[e.RowIndex].Cells[3].Value.ToString();
            group_cari_pelanggan.Visible = false;
        }

        private void dg_barang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode_barang.Text = dg_barang.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nama_barang.Text = dg_barang.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_harga_barang.Text = dg_barang.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_satuan_barang.Text = dg_barang.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_stock_barang.Text = dg_barang.Rows[e.RowIndex].Cells[4].Value.ToString();
            group_cari_barang.Visible = false;
        }

        private void dg_penjualan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_no_penjualan.Text = dg_penjualan.Rows[e.RowIndex].Cells[0].Value.ToString();
            dg_pelanggan_CellContentClick(sender, e);
            dg_barang_CellContentClick(sender, e);
            txt_jumlah_penjualan.Text = dg_penjualan.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_sub_total.Text = dg_penjualan.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_terbilang.Text = dg_penjualan.Rows[e.RowIndex].Cells[6].Value.ToString();
            txt_jenis_bayar.Text = dg_penjualan.Rows[e.RowIndex].Cells[7].Value.ToString();
            DisplayData();
        }

        private void txt_jumlah_penjualan_TextChanged(object sender, EventArgs e)
        {
            if (txt_jumlah_penjualan.Text != "")
                txt_sub_total.Text = (int.Parse(txt_jumlah_penjualan.Text) * int.Parse(txt_harga_barang.Text)).ToString();
        }

        private void txt_sub_total_TextChanged(object sender, EventArgs e)
        {
            if (txt_sub_total.Text != "")
                txt_terbilang.Text = Terbilang(int.Parse(txt_sub_total.Text)) + " Rupiah";


        }

        public static string Terbilang(int x)
        {
            string[] bilangan = { "", "Satu", "Dua", "Tiga", "Empat", "Lima", "Enam", "Tujuh", "Delapan", "Sembilan", "Sepuluh", "Sebelas" };
            string temp = "";
            if (x < 12)
            {
                temp = "" + bilangan[x];
            }
            else if (x < 20)
            {
                temp = Terbilang(x - 10).ToString() + " Belas ";
            }
            else if (x < 100)
            {
                temp = Terbilang(x / 10) + " Puluh " + Terbilang(x % 10);
            }
            else if (x < 200)
            {
                temp = " Seratus " + Terbilang(x - 100);
            }
            else if (x < 1000)
            {
                temp = Terbilang(x / 100) + " Ratus " + Terbilang(x % 100);
            }
            else if (x < 2000)
            {
                temp = " Seribu" + Terbilang(x - 1000);
            }
            else if (x < 1000000)
            {
                temp = Terbilang(x / 1000) + " Ribu " + Terbilang(x % 1000);
            }
            else if (x < 1000000000)
            {
                temp = Terbilang(x / 1000000) + " Juta " + Terbilang(x % 1000000);
            }

            return temp;
        }
    }
}
