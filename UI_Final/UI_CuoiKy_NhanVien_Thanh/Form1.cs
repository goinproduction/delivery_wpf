using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.manvgiahan = tentknv.Text;
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.temp1 = tentknv.Text;
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tentknv.Text = temp;
        }
        public string temp = "NV1"; //Biến này dùng để lấy tên đăng nhập khi nhân viên đăng nhập thành công
        // vì chưa có form đăng nhập nên gán cho biến này bằng 1 tên đăng nhập của nhân viên bất kỳ
    }
}
