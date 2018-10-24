using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace merryscol
{
    public partial class FRM_MENU_UTAMA : Form
    {
        public FRM_MENU_UTAMA()
        {
            InitializeComponent();
        }

        private void FRM_MENU_UTAMA_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PENJUALAN FPENJUALAN = new FRM_PENJUALAN();
            FPENJUALAN.MdiParent = this;
            FPENJUALAN.Show();
        }

        private void dataBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_BARANG FBARANG = new FRM_BARANG();
            FBARANG.MdiParent = this;
            FBARANG.Show();
        }

        private void dataPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PELANGGAN FPELANGGAN = new FRM_PELANGGAN();
            FPELANGGAN.MdiParent = this;
            FPELANGGAN.Show();
        }

        private void dataSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SUPPLIER FPSUPPLIER = new FRM_SUPPLIER();
            FPSUPPLIER.MdiParent = this;
            FPSUPPLIER.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ORDER FORDER = new FRM_ORDER();
            FORDER.MdiParent = this;
            FORDER.Show();
        }

        private void penerimaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PENERIMAAN FPENERIMAAN = new FRM_PENERIMAAN();
            FPENERIMAAN.MdiParent = this;
            FPENERIMAAN.Show();
        }

        private void dataBarangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Laporan_Barang PRINTBARANG = new Laporan_Barang();
            PRINTBARANG.MdiParent = this;
            PRINTBARANG.Show();
        }
    }
}
