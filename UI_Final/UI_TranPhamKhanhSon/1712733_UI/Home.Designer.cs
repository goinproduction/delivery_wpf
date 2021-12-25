
namespace _1712733_UI
{
    partial class Home
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
            this.btnReadInfor = new System.Windows.Forms.Button();
            this.btnDanhSachSP = new System.Windows.Forms.Button();
            this.btnDanhSachDonHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chức năng hệ thống";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnReadInfor
            // 
            this.btnReadInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadInfor.Location = new System.Drawing.Point(131, 136);
            this.btnReadInfor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReadInfor.Name = "btnReadInfor";
            this.btnReadInfor.Size = new System.Drawing.Size(464, 67);
            this.btnReadInfor.TabIndex = 2;
            this.btnReadInfor.Text = "Thông tin đối tác";
            this.btnReadInfor.UseVisualStyleBackColor = true;
            // 
            // btnDanhSachSP
            // 
            this.btnDanhSachSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachSP.Location = new System.Drawing.Point(131, 241);
            this.btnDanhSachSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDanhSachSP.Name = "btnDanhSachSP";
            this.btnDanhSachSP.Size = new System.Drawing.Size(464, 60);
            this.btnDanhSachSP.TabIndex = 3;
            this.btnDanhSachSP.Text = "Danh sách sản phẩm";
            this.btnDanhSachSP.UseVisualStyleBackColor = true;
            this.btnDanhSachSP.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDanhSachDonHang
            // 
            this.btnDanhSachDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachDonHang.Location = new System.Drawing.Point(131, 354);
            this.btnDanhSachDonHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDanhSachDonHang.Name = "btnDanhSachDonHang";
            this.btnDanhSachDonHang.Size = new System.Drawing.Size(464, 62);
            this.btnDanhSachDonHang.TabIndex = 4;
            this.btnDanhSachDonHang.Text = "Danh sách đơn hàng";
            this.btnDanhSachDonHang.UseVisualStyleBackColor = true;
            this.btnDanhSachDonHang.Click += new System.EventHandler(this.button2_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.btnDanhSachDonHang);
            this.Controls.Add(this.btnDanhSachSP);
            this.Controls.Add(this.btnReadInfor);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadInfor;
        private System.Windows.Forms.Button btnDanhSachSP;
        private System.Windows.Forms.Button btnDanhSachDonHang;
    }
}

