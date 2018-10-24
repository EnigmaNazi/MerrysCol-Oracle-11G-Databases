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
    public partial class FRM_MASUK : Form
    {
        public FRM_MASUK()
        {
            InitializeComponent();
        }

        private void merryscol_Click(object sender, EventArgs e)
        {
            FRM_LOGIN FLOGMER = new FRM_LOGIN();
            FLOGMER.Show();
        }

        private void metrocom_Click(object sender, EventArgs e)
        {
            LOGIN_METRO FLOGMET = new LOGIN_METRO();
            FLOGMET.Show();
        }
    }
}
