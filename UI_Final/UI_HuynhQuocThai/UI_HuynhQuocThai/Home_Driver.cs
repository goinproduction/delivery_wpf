using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_HuynhQuocThai
{
    public partial class Home_Driver : Form
    {
        public Home_Driver()
        {
            InitializeComponent();
        }

        private void btnReadInfor_Click(object sender, EventArgs e)
        {
            DriverInfor driverinfor = new DriverInfor();
            driverinfor.Show();
        }

        private void btnFindOrder_Click(object sender, EventArgs e)
        {
            FindOrder findorder = new FindOrder();
            findorder.Show();
        }

        private void btnReadOrdered_Click(object sender, EventArgs e)
        {
            InforOrdered inforordered = new InforOrdered();
            inforordered.Show();
        }
    }
}
