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
    public partial class MENU_METRO : Form
    {
        public MENU_METRO()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BARANGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BARANG_METRO FRMbrg = new BARANG_METRO();
            FRMbrg.MdiParent = this;
            FRMbrg.Show();
        }

        private void pELANGGANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PELANGGAN_METRO FPELANGGAN = new PELANGGAN_METRO();
            FPELANGGAN.MdiParent = this;
            FPELANGGAN.Show();
        }

        private void pENJUALANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PENJUALAN_METRO FPENJUALAN = new PENJUALAN_METRO();
            FPENJUALAN.MdiParent = this;
            FPENJUALAN.Show();
        }
    }
}
