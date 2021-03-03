using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject_ADO_Ali
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTourist_Click(object sender, EventArgs e)
        {
            Tourist tr = new Tourist();
            this.Hide();
            tr.ShowDialog();
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            Hotel ho = new Hotel();
            this.Hide();
            ho.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            TouristReport rpt = new TouristReport();
            this.Hide();
            rpt.ShowDialog();
        }
    }
}
