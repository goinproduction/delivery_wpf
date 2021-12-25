namespace UI
{
    partial class ThanhToan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_GioHang = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_TenKhachHang = new System.Windows.Forms.TextBox();
            this.tb_MaKhachHang = new System.Windows.Forms.TextBox();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_HinhThucThanhToan = new System.Windows.Forms.TextBox();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.tb_MaDonHang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_GioHang);
            this.groupBox1.Location = new System.Drawing.Point(377, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 359);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giỏ hàng";
            // 
            // dgv_GioHang
            // 
            this.dgv_GioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GioHang.Location = new System.Drawing.Point(6, 19);
            this.dgv_GioHang.Name = "dgv_GioHang";
            this.dgv_GioHang.Size = new System.Drawing.Size(390, 334);
            this.dgv_GioHang.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin giao hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Địa chỉ giao hàng";
            // 
            // tb_TenKhachHang
            // 
            this.tb_TenKhachHang.Location = new System.Drawing.Point(139, 183);
            this.tb_TenKhachHang.Name = "tb_TenKhachHang";
            this.tb_TenKhachHang.Size = new System.Drawing.Size(100, 20);
            this.tb_TenKhachHang.TabIndex = 6;
            // 
            // tb_MaKhachHang
            // 
            this.tb_MaKhachHang.Location = new System.Drawing.Point(139, 155);
            this.tb_MaKhachHang.Name = "tb_MaKhachHang";
            this.tb_MaKhachHang.Size = new System.Drawing.Size(100, 20);
            this.tb_MaKhachHang.TabIndex = 7;
            // 
            // tb_SDT
            // 
            this.tb_SDT.Location = new System.Drawing.Point(139, 212);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.Size = new System.Drawing.Size(100, 20);
            this.tb_SDT.TabIndex = 8;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(139, 242);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(174, 96);
            this.tb_DiaChi.TabIndex = 9;
            this.tb_DiaChi.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hình thức thanh toán";
            // 
            // tb_HinhThucThanhToan
            // 
            this.tb_HinhThucThanhToan.Location = new System.Drawing.Point(139, 390);
            this.tb_HinhThucThanhToan.Name = "tb_HinhThucThanhToan";
            this.tb_HinhThucThanhToan.Size = new System.Drawing.Size(100, 20);
            this.tb_HinhThucThanhToan.TabIndex = 11;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(682, 406);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(97, 32);
            this.btn_ThanhToan.TabIndex = 12;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Email";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(139, 355);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(100, 20);
            this.tb_Email.TabIndex = 14;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(245, 153);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 23);
            this.btn_Load.TabIndex = 16;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // tb_MaDonHang
            // 
            this.tb_MaDonHang.Location = new System.Drawing.Point(139, 422);
            this.tb_MaDonHang.Name = "tb_MaDonHang";
            this.tb_MaDonHang.Size = new System.Drawing.Size(100, 20);
            this.tb_MaDonHang.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mã đơn hàng";
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_MaDonHang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.tb_HinhThucThanhToan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.tb_SDT);
            this.Controls.Add(this.tb_MaKhachHang);
            this.Controls.Add(this.tb_TenKhachHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThanhToan";
            this.Text = "ThanhToan";
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GioHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_GioHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_TenKhachHang;
        private System.Windows.Forms.TextBox tb_MaKhachHang;
        private System.Windows.Forms.TextBox tb_SDT;
        private System.Windows.Forms.RichTextBox tb_DiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_HinhThucThanhToan;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.TextBox tb_MaDonHang;
        private System.Windows.Forms.Label label8;
    }
}