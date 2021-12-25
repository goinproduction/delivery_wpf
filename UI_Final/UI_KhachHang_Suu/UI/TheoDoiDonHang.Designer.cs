namespace UI
{
    partial class TheoDoiDonHang
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
            this.tb_MaDonHang = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_TTDH = new System.Windows.Forms.DataGridView();
            this.tb_TheoDoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TTDH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn hàng";
            // 
            // tb_MaDonHang
            // 
            this.tb_MaDonHang.Location = new System.Drawing.Point(90, 19);
            this.tb_MaDonHang.Name = "tb_MaDonHang";
            this.tb_MaDonHang.Size = new System.Drawing.Size(145, 20);
            this.tb_MaDonHang.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_TTDH);
            this.groupBox1.Location = new System.Drawing.Point(16, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 137);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // dgv_TTDH
            // 
            this.dgv_TTDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TTDH.Location = new System.Drawing.Point(6, 19);
            this.dgv_TTDH.Name = "dgv_TTDH";
            this.dgv_TTDH.Size = new System.Drawing.Size(426, 112);
            this.dgv_TTDH.TabIndex = 0;
            // 
            // tb_TheoDoi
            // 
            this.tb_TheoDoi.Location = new System.Drawing.Point(255, 17);
            this.tb_TheoDoi.Name = "tb_TheoDoi";
            this.tb_TheoDoi.Size = new System.Drawing.Size(75, 23);
            this.tb_TheoDoi.TabIndex = 3;
            this.tb_TheoDoi.Text = "Theo dõi";
            this.tb_TheoDoi.UseVisualStyleBackColor = true;
            this.tb_TheoDoi.Click += new System.EventHandler(this.tb_TheoDoi_Click);
            // 
            // TheoDoiDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_TheoDoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_MaDonHang);
            this.Controls.Add(this.label1);
            this.Name = "TheoDoiDonHang";
            this.Text = "Theo dõi đơn hàng";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TTDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_MaDonHang;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_TTDH;
        private System.Windows.Forms.Button tb_TheoDoi;
    }
}