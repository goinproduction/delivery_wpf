namespace UI
{
    partial class KhachHang_Main
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
            this.btn_DatHang = new System.Windows.Forms.Button();
            this.btn_TheoiDoiDonHang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_DatHang
            // 
            this.btn_DatHang.Location = new System.Drawing.Point(293, 147);
            this.btn_DatHang.Name = "btn_DatHang";
            this.btn_DatHang.Size = new System.Drawing.Size(165, 47);
            this.btn_DatHang.TabIndex = 0;
            this.btn_DatHang.Text = "ĐẶT HÀNG";
            this.btn_DatHang.UseVisualStyleBackColor = true;
            this.btn_DatHang.Click += new System.EventHandler(this.btn_DatHang_Click);
            // 
            // btn_TheoiDoiDonHang
            // 
            this.btn_TheoiDoiDonHang.Location = new System.Drawing.Point(293, 219);
            this.btn_TheoiDoiDonHang.Name = "btn_TheoiDoiDonHang";
            this.btn_TheoiDoiDonHang.Size = new System.Drawing.Size(165, 47);
            this.btn_TheoiDoiDonHang.TabIndex = 1;
            this.btn_TheoiDoiDonHang.Text = "THEO DÕI ĐƠN HÀNG";
            this.btn_TheoiDoiDonHang.UseVisualStyleBackColor = true;
            this.btn_TheoiDoiDonHang.Click += new System.EventHandler(this.btn_TheoiDoiDonHang_Click);
            // 
            // KhachHang_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_TheoiDoiDonHang);
            this.Controls.Add(this.btn_DatHang);
            this.Name = "KhachHang_Main";
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_DatHang;
        private System.Windows.Forms.Button btn_TheoiDoiDonHang;
    }
}