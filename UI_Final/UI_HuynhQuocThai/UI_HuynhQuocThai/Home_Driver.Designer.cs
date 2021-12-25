
namespace UI_HuynhQuocThai
{
    partial class Home_Driver
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
            this.btnFindOrder = new System.Windows.Forms.Button();
            this.btnReadOrdered = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chức năng hệ thống";
            // 
            // btnReadInfor
            // 
            this.btnReadInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadInfor.Location = new System.Drawing.Point(153, 118);
            this.btnReadInfor.Name = "btnReadInfor";
            this.btnReadInfor.Size = new System.Drawing.Size(562, 91);
            this.btnReadInfor.TabIndex = 1;
            this.btnReadInfor.Text = "Xem thông tin cá nhân";
            this.btnReadInfor.UseVisualStyleBackColor = true;
            this.btnReadInfor.Click += new System.EventHandler(this.btnReadInfor_Click);
            // 
            // btnFindOrder
            // 
            this.btnFindOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindOrder.Location = new System.Drawing.Point(153, 240);
            this.btnFindOrder.Name = "btnFindOrder";
            this.btnFindOrder.Size = new System.Drawing.Size(562, 91);
            this.btnFindOrder.TabIndex = 2;
            this.btnFindOrder.Text = "Tìm kiếm đơn hàng trong khu vực";
            this.btnFindOrder.UseVisualStyleBackColor = true;
            this.btnFindOrder.Click += new System.EventHandler(this.btnFindOrder_Click);
            // 
            // btnReadOrdered
            // 
            this.btnReadOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadOrdered.Location = new System.Drawing.Point(153, 369);
            this.btnReadOrdered.Name = "btnReadOrdered";
            this.btnReadOrdered.Size = new System.Drawing.Size(562, 91);
            this.btnReadOrdered.TabIndex = 3;
            this.btnReadOrdered.Text = "Xem thông tin đơn hàng đã nhận";
            this.btnReadOrdered.UseVisualStyleBackColor = true;
            this.btnReadOrdered.Click += new System.EventHandler(this.btnReadOrdered_Click);
            // 
            // Home_Driver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(906, 540);
            this.Controls.Add(this.btnReadOrdered);
            this.Controls.Add(this.btnFindOrder);
            this.Controls.Add(this.btnReadInfor);
            this.Controls.Add(this.label1);
            this.Name = "Home_Driver";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadInfor;
        private System.Windows.Forms.Button btnFindOrder;
        private System.Windows.Forms.Button btnReadOrdered;
    }
}