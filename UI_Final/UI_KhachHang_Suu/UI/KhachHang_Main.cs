using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class KhachHang_Main : Form
    {
        public KhachHang_Main()
        {
            InitializeComponent();
        }

        private void btn_DatHang_Click(object sender, EventArgs e)
        {
            DatHang dh = new DatHang();
            dh.Show();
        }

        private void btn_TheoiDoiDonHang_Click(object sender, EventArgs e)
        {
            TheoDoiDonHang tddh = new TheoDoiDonHang();
            tddh.Show();
        }
    }
}
