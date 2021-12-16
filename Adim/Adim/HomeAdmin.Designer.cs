namespace Adim
{
    partial class adminHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Home_Text_Chucnanghethong = new System.Windows.Forms.Label();
            this.HomeAdminListAccount = new System.Windows.Forms.Button();
            this.HomeAdminThemTaiKhoan = new System.Windows.Forms.Button();
            this.HomeAdminXoaTaiKhoan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Home_Text_Chucnanghethong
            // 
            this.Home_Text_Chucnanghethong.AutoSize = true;
            this.Home_Text_Chucnanghethong.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Home_Text_Chucnanghethong.ForeColor = System.Drawing.Color.White;
            this.Home_Text_Chucnanghethong.Location = new System.Drawing.Point(73, 71);
            this.Home_Text_Chucnanghethong.Name = "Home_Text_Chucnanghethong";
            this.Home_Text_Chucnanghethong.Size = new System.Drawing.Size(429, 48);
            this.Home_Text_Chucnanghethong.TabIndex = 0;
            this.Home_Text_Chucnanghethong.Text = "Chức năng hệ thống";
            // 
            // HomeAdminListAccount
            // 
            this.HomeAdminListAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HomeAdminListAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
            this.HomeAdminListAccount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeAdminListAccount.Location = new System.Drawing.Point(372, 218);
            this.HomeAdminListAccount.Name = "HomeAdminListAccount";
            this.HomeAdminListAccount.Size = new System.Drawing.Size(362, 78);
            this.HomeAdminListAccount.TabIndex = 1;
            this.HomeAdminListAccount.Text = "Danh sách tài khoản trong hệ thống";
            this.HomeAdminListAccount.UseVisualStyleBackColor = false;
            // 
            // HomeAdminThemTaiKhoan
            // 
            this.HomeAdminThemTaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.HomeAdminThemTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeAdminThemTaiKhoan.Location = new System.Drawing.Point(372, 365);
            this.HomeAdminThemTaiKhoan.Name = "HomeAdminThemTaiKhoan";
            this.HomeAdminThemTaiKhoan.Size = new System.Drawing.Size(362, 78);
            this.HomeAdminThemTaiKhoan.TabIndex = 2;
            this.HomeAdminThemTaiKhoan.Text = "Thêm tài khoản";
            this.HomeAdminThemTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // HomeAdminXoaTaiKhoan
            // 
            this.HomeAdminXoaTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HomeAdminXoaTaiKhoan.Location = new System.Drawing.Point(372, 502);
            this.HomeAdminXoaTaiKhoan.Name = "HomeAdminXoaTaiKhoan";
            this.HomeAdminXoaTaiKhoan.Size = new System.Drawing.Size(362, 78);
            this.HomeAdminXoaTaiKhoan.TabIndex = 3;
            this.HomeAdminXoaTaiKhoan.Text = "Xóa tài khoản";
            this.HomeAdminXoaTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // adminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(94)))), ((int)(((byte)(107)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1087, 641);
            this.Controls.Add(this.HomeAdminXoaTaiKhoan);
            this.Controls.Add(this.HomeAdminThemTaiKhoan);
            this.Controls.Add(this.HomeAdminListAccount);
            this.Controls.Add(this.Home_Text_Chucnanghethong);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "adminHome";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Home_Text_Chucnanghethong;
        private Button HomeAdminListAccount;
        private Button HomeAdminThemTaiKhoan;
        private Button HomeAdminXoaTaiKhoan;
    }
}