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
    public partial class PELANGGAN_METRO : Form
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
            cmd = new OracleCommand("select kode_pelanggan from pelanggan_metro where kode_pelanggan in(select max(kode_pelanggan) from tbl_pelanggan) order by kode_pelanggan desc", con);
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
            txt_kode_plg.Text = urut;
            con.Close();
        }

        //untuk clear text
        private void cleartext()
        {
            txt_kode_plg.Enabled = false;
            txt_nama_plg.Text = "";
            txt_notelp_plg.Text = "";
            txt_alamat_plg.Text = "";
        }

        public PELANGGAN_METRO()
        {
            InitializeComponent();
            cleartext();
            DisplayData();
        }

        private void btn_new_plg_Click(object sender, EventArgs e)
        {
            otomatis();
        }

        private void btn_save_plg_Click(object sender, EventArgs e)
        {
            if (txt_kode_plg.Text != "" && txt_nama_plg.Text != "" && txt_notelp_plg.Text != "" && txt_alamat_plg.Text != "")
            {
                cmd = new OracleCommand("insert into pelanggan_metro(kode_pelanggan,nama_pelanggan,no_telp,alamat) values('" + txt_kode_plg.Text + "','" + txt_nama_plg.Text + "','" + txt_notelp_plg.Text + "','" + txt_alamat_plg.Text + "')", con);
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

        private void btn_edit_plg_Click(object sender, EventArgs e)
        {
            if (txt_kode_plg.Text != "" && txt_nama_plg.Text != "" && txt_notelp_plg.Text != "" && txt_alamat_plg.Text != "")
            {
                cmd = new OracleCommand("update pelanggan_metro set nama_pelanggan='" + txt_nama_plg.Text + "',no_telp='" + txt_notelp_plg.Text + "',alamat='" + txt_alamat_plg.Text + "' where kode_pelanggan='" + txt_kode_plg.Text + "'", con);

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Edit Berhasil");
                con.Close();
                DisplayData();
                cleartext();
            }
            else
            {
                MessageBox.Show("gagal edit");
            }
        }

        private void btn_delete_plg_Click(object sender, EventArgs e)
        {
            if (txt_kode_plg.Text != "" && txt_nama_plg.Text != "" && txt_notelp_plg.Text != "" && txt_alamat_plg.Text != "")
            {
                cmd = new OracleCommand("delete pelanggan_metro where kode_pelanggan='" + txt_kode_plg.Text + "'", con);
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

        private void btn_close_plg_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dg_pelanggan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_kode_plg.Text = dg_pelanggan.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nama_plg.Text = dg_pelanggan.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_notelp_plg.Text = dg_pelanggan.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_alamat_plg.Text = dg_pelanggan.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_kode_plg.Enabled = false;
        }
    }
}
