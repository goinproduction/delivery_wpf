namespace Adim
{
    partial class XemDanhSachTaiKhoanAdmin
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
            this.DanhSachTaiKhoanAdminLabel = new System.Windows.Forms.Label();
            this.danhSachTaiKhoanAdminDataGridView = new System.Windows.Forms.DataGridView();
            this.XemDanhSachTaiKhoanAdminUpdate = new System.Windows.Forms.Button();
            this.DanhSachTaiKhoanAdminBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachTaiKhoanAdminDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DanhSachTaiKhoanAdminLabel
            // 
            this.DanhSachTaiKhoanAdminLabel.AutoSize = true;
            this.DanhSachTaiKhoanAdminLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DanhSachTaiKhoanAdminLabel.ForeColor = System.Drawing.Color.White;
            this.DanhSachTaiKhoanAdminLabel.Location = new System.Drawing.Point(43, 53);
            this.DanhSachTaiKhoanAdminLabel.Name = "DanhSachTaiKhoanAdminLabel";
            this.DanhSachTaiKhoanAdminLabel.Size = new System.Drawing.Size(364, 28);
            this.DanhSachTaiKhoanAdminLabel.TabIndex = 0;
            this.DanhSachTaiKhoanAdminLabel.Text = "Các tài khoản hiện có trong hệ thống";
            // 
            // danhSachTaiKhoanAdminDataGridView
            // 
            this.danhSachTaiKhoanAdminDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachTaiKhoanAdminDataGridView.Location = new System.Drawing.Point(43, 175);
            this.danhSachTaiKhoanAdminDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.danhSachTaiKhoanAdminDataGridView.Name = "danhSachTaiKhoanAdminDataGridView";
            this.danhSachTaiKhoanAdminDataGridView.RowHeadersWidth = 51;
            this.danhSachTaiKhoanAdminDataGridView.RowTemplate.Height = 29;
            this.danhSachTaiKhoanAdminDataGridView.Size = new System.Drawing.Size(863, 182);
            this.danhSachTaiKhoanAdminDataGridView.TabIndex = 1;
            // 
            // XemDanhSachTaiKhoanAdminUpdate
            // 
            this.XemDanhSachTaiKhoanAdminUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.XemDanhSachTaiKhoanAdminUpdate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.XemDanhSachTaiKhoanAdminUpdate.Location = new System.Drawing.Point(559, 404);
            this.XemDanhSachTaiKhoanAdminUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XemDanhSachTaiKhoanAdminUpdate.Name = "XemDanhSachTaiKhoanAdminUpdate";
            this.XemDanhSachTaiKhoanAdminUpdate.Size = new System.Drawing.Size(172, 48);
            this.XemDanhSachTaiKhoanAdminUpdate.TabIndex = 2;
            this.XemDanhSachTaiKhoanAdminUpdate.Text = "Cập nhật";
            this.XemDanhSachTaiKhoanAdminUpdate.UseVisualStyleBackColor = false;
            // 
            // DanhSachTaiKhoanAdminBackButton
            // 
            this.DanhSachTaiKhoanAdminBackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.DanhSachTaiKhoanAdminBackButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DanhSachTaiKhoanAdminBackButton.Location = new System.Drawing.Point(43, 404);
            this.DanhSachTaiKhoanAdminBackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DanhSachTaiKhoanAdminBackButton.Name = "DanhSachTaiKhoanAdminBackButton";
            this.DanhSachTaiKhoanAdminBackButton.Size = new System.Drawing.Size(172, 48);
            this.DanhSachTaiKhoanAdminBackButton.TabIndex = 3;
            this.DanhSachTaiKhoanAdminBackButton.Text = "Back";
            this.DanhSachTaiKhoanAdminBackButton.UseVisualStyleBackColor = false;
            this.DanhSachTaiKhoanAdminBackButton.Click += new System.EventHandler(this.DanhSachTaiKhoanAdminBackButton_Click);
            // 
            // XemDanhSachTaiKhoanAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(94)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(951, 481);
            this.Controls.Add(this.DanhSachTaiKhoanAdminBackButton);
            this.Controls.Add(this.XemDanhSachTaiKhoanAdminUpdate);
            this.Controls.Add(this.danhSachTaiKhoanAdminDataGridView);
            this.Controls.Add(this.DanhSachTaiKhoanAdminLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XemDanhSachTaiKhoanAdmin";
            this.Text = "Danh sách tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.danhSachTaiKhoanAdminDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label DanhSachTaiKhoanAdminLabel;
        private DataGridView danhSachTaiKhoanAdminDataGridView;
        private Button XemDanhSachTaiKhoanAdminUpdate;
        private Button DanhSachTaiKhoanAdminBackButton;
        private Button button1;
    }
}