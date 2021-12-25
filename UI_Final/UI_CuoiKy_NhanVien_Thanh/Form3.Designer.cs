
namespace WindowsFormsApp1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.timkiem = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tendoitac = new System.Windows.Forms.TextBox();
            this.madoitac = new System.Windows.Forms.TextBox();
            this.sodt = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.TextBox();
            this.slchinhanh = new System.Windows.Forms.TextBox();
            this.doanhthu = new System.Windows.Forms.TextBox();
            this.ngaydaohan = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.mahopdong = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên đối tác";
            // 
            // timkiem
            // 
            this.timkiem.Location = new System.Drawing.Point(14, 39);
            this.timkiem.Name = "timkiem";
            this.timkiem.Size = new System.Drawing.Size(716, 24);
            this.timkiem.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(736, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sách đối tác";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(851, 174);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên đối tác";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã đối tác";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(412, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(412, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 18);
            this.label8.TabIndex = 10;
            this.label8.Text = "Số lượng chi nhánh";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(412, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Doanh thu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(412, 461);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ngày đáo hạn hợp đồng";
            // 
            // tendoitac
            // 
            this.tendoitac.Location = new System.Drawing.Point(133, 347);
            this.tendoitac.Name = "tendoitac";
            this.tendoitac.Size = new System.Drawing.Size(225, 24);
            this.tendoitac.TabIndex = 13;
            // 
            // madoitac
            // 
            this.madoitac.Location = new System.Drawing.Point(133, 386);
            this.madoitac.Name = "madoitac";
            this.madoitac.Size = new System.Drawing.Size(225, 24);
            this.madoitac.TabIndex = 14;
            // 
            // sodt
            // 
            this.sodt.Location = new System.Drawing.Point(133, 424);
            this.sodt.Name = "sodt";
            this.sodt.Size = new System.Drawing.Size(225, 24);
            this.sodt.TabIndex = 15;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(133, 461);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(225, 24);
            this.email.TabIndex = 16;
            // 
            // diachi
            // 
            this.diachi.Location = new System.Drawing.Point(592, 347);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(273, 24);
            this.diachi.TabIndex = 17;
            // 
            // slchinhanh
            // 
            this.slchinhanh.Location = new System.Drawing.Point(592, 386);
            this.slchinhanh.Name = "slchinhanh";
            this.slchinhanh.Size = new System.Drawing.Size(273, 24);
            this.slchinhanh.TabIndex = 18;
            // 
            // doanhthu
            // 
            this.doanhthu.Location = new System.Drawing.Point(592, 424);
            this.doanhthu.Name = "doanhthu";
            this.doanhthu.Size = new System.Drawing.Size(273, 24);
            this.doanhthu.TabIndex = 19;
            // 
            // ngaydaohan
            // 
            this.ngaydaohan.Location = new System.Drawing.Point(592, 461);
            this.ngaydaohan.Name = "ngaydaohan";
            this.ngaydaohan.Size = new System.Drawing.Size(273, 24);
            this.ngaydaohan.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(684, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 50);
            this.button2.TabIndex = 21;
            this.button2.Text = "Gia hạn hợp đồng";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(11, 498);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Mã hợp đồng";
            // 
            // mahopdong
            // 
            this.mahopdong.Location = new System.Drawing.Point(133, 498);
            this.mahopdong.Name = "mahopdong";
            this.mahopdong.Size = new System.Drawing.Size(225, 24);
            this.mahopdong.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(736, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 30);
            this.button3.TabIndex = 24;
            this.button3.Text = "Tải Lại";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Coral;
            this.label12.Location = new System.Drawing.Point(14, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(539, 18);
            this.label12.TabIndex = 25;
            this.label12.Text = "*Click vào bất cứ ô nào thuộc hàng của đối tác để xem thông tin chi tiết về đối t" +
    "ác";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(877, 575);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mahopdong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ngaydaohan);
            this.Controls.Add(this.doanhthu);
            this.Controls.Add(this.slchinhanh);
            this.Controls.Add(this.diachi);
            this.Controls.Add(this.email);
            this.Controls.Add(this.sodt);
            this.Controls.Add(this.madoitac);
            this.Controls.Add(this.tendoitac);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timkiem);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form3";
            this.Text = "Thông Tin Đối Tác";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timkiem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tendoitac;
        private System.Windows.Forms.TextBox madoitac;
        private System.Windows.Forms.TextBox sodt;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox diachi;
        private System.Windows.Forms.TextBox slchinhanh;
        private System.Windows.Forms.TextBox doanhthu;
        private System.Windows.Forms.TextBox ngaydaohan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox mahopdong;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
    }
}