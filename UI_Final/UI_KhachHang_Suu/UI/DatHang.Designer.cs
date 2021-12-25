namespace UI
{
    partial class DatHang
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
            this.dgv_DanhSachDoiTac = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachSanPham = new System.Windows.Forms.DataGridView();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_MaSanPham = new System.Windows.Forms.TextBox();
            this.btn_ThemVaoGio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_SoLuongMua = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_MaDoiTac = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_XemDSSanPham = new System.Windows.Forms.Button();
            this.tb_MaGio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDoiTac)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_DanhSachDoiTac);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(396, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đối tác";
            // 
            // dgv_DanhSachDoiTac
            // 
            this.dgv_DanhSachDoiTac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachDoiTac.Location = new System.Drawing.Point(0, 19);
            this.dgv_DanhSachDoiTac.Name = "dgv_DanhSachDoiTac";
            this.dgv_DanhSachDoiTac.Size = new System.Drawing.Size(390, 110);
            this.dgv_DanhSachDoiTac.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_DanhSachSanPham);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 135);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dgv_DanhSachSanPham
            // 
            this.dgv_DanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachSanPham.Location = new System.Drawing.Point(6, 19);
            this.dgv_DanhSachSanPham.Name = "dgv_DanhSachSanPham";
            this.dgv_DanhSachSanPham.Size = new System.Drawing.Size(384, 110);
            this.dgv_DanhSachSanPham.TabIndex = 0;
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(702, 468);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(157, 34);
            this.btn_ThanhToan.TabIndex = 2;
            this.btn_ThanhToan.Text = "Xem giỏ hàng và Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chọn mặt hàng để thêm vào giỏ hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã sản phẩm";
            // 
            // tb_MaSanPham
            // 
            this.tb_MaSanPham.Location = new System.Drawing.Point(100, 423);
            this.tb_MaSanPham.Name = "tb_MaSanPham";
            this.tb_MaSanPham.Size = new System.Drawing.Size(109, 20);
            this.tb_MaSanPham.TabIndex = 5;
            // 
            // btn_ThemVaoGio
            // 
            this.btn_ThemVaoGio.Location = new System.Drawing.Point(12, 485);
            this.btn_ThemVaoGio.Name = "btn_ThemVaoGio";
            this.btn_ThemVaoGio.Size = new System.Drawing.Size(123, 23);
            this.btn_ThemVaoGio.TabIndex = 6;
            this.btn_ThemVaoGio.Text = "Thêm vào giỏ";
            this.btn_ThemVaoGio.UseVisualStyleBackColor = true;
            this.btn_ThemVaoGio.Click += new System.EventHandler(this.btn_ThemVaoGio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số lượng";
            // 
            // tb_SoLuongMua
            // 
            this.tb_SoLuongMua.Location = new System.Drawing.Point(100, 451);
            this.tb_SoLuongMua.Name = "tb_SoLuongMua";
            this.tb_SoLuongMua.Size = new System.Drawing.Size(63, 20);
            this.tb_SoLuongMua.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã đối tác";
            // 
            // tb_MaDoiTac
            // 
            this.tb_MaDoiTac.Location = new System.Drawing.Point(92, 172);
            this.tb_MaDoiTac.Name = "tb_MaDoiTac";
            this.tb_MaDoiTac.Size = new System.Drawing.Size(109, 20);
            this.tb_MaDoiTac.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Xem danh sách sản phẩm theo đối tác";
            // 
            // btn_XemDSSanPham
            // 
            this.btn_XemDSSanPham.Location = new System.Drawing.Point(207, 170);
            this.btn_XemDSSanPham.Name = "btn_XemDSSanPham";
            this.btn_XemDSSanPham.Size = new System.Drawing.Size(150, 23);
            this.btn_XemDSSanPham.TabIndex = 27;
            this.btn_XemDSSanPham.Text = "Xem danh sách sản phẩm";
            this.btn_XemDSSanPham.UseVisualStyleBackColor = true;
            this.btn_XemDSSanPham.Click += new System.EventHandler(this.btn_XemDSSanPham_Click);
            // 
            // tb_MaGio
            // 
            this.tb_MaGio.Location = new System.Drawing.Point(100, 397);
            this.tb_MaGio.Name = "tb_MaGio";
            this.tb_MaGio.Size = new System.Drawing.Size(109, 20);
            this.tb_MaGio.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Mã giỏ";
            // 
            // DatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 512);
            this.Controls.Add(this.tb_MaGio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_XemDSSanPham);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_MaDoiTac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_SoLuongMua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ThemVaoGio);
            this.Controls.Add(this.tb_MaSanPham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DatHang";
            this.Text = "Đặt hàng";
            this.Load += new System.EventHandler(this.DatHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachDoiTac)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_DanhSachDoiTac;
        private System.Windows.Forms.DataGridView dgv_DanhSachSanPham;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_MaSanPham;
        private System.Windows.Forms.Button btn_ThemVaoGio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_SoLuongMua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_MaDoiTac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_XemDSSanPham;
        private System.Windows.Forms.TextBox tb_MaGio;
        private System.Windows.Forms.Label label6;
    }
}

