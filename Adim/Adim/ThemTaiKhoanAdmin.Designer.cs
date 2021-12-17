namespace Adim
{
    partial class ThemTaiKhoanAdmin
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
            this.ThemTaiKhoanAdminPanel = new System.Windows.Forms.Panel();
            this.TenDangNhapAdminGroupBox = new System.Windows.Forms.GroupBox();
            this.TenDangNhapAdminSubTextbox = new System.Windows.Forms.TextBox();
            this.ThemTaiKhoanAdminLable = new System.Windows.Forms.Label();
            this.ThemTaiKhoanAdminPanel.SuspendLayout();
            this.TenDangNhapAdminGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThemTaiKhoanAdminPanel
            // 
            this.ThemTaiKhoanAdminPanel.BackColor = System.Drawing.Color.White;
            this.ThemTaiKhoanAdminPanel.Controls.Add(this.TenDangNhapAdminGroupBox);
            this.ThemTaiKhoanAdminPanel.Controls.Add(this.ThemTaiKhoanAdminLable);
            this.ThemTaiKhoanAdminPanel.Location = new System.Drawing.Point(314, 56);
            this.ThemTaiKhoanAdminPanel.Name = "ThemTaiKhoanAdminPanel";
            this.ThemTaiKhoanAdminPanel.Size = new System.Drawing.Size(477, 575);
            this.ThemTaiKhoanAdminPanel.TabIndex = 1;
            // 
            // TenDangNhapAdminGroupBox
            // 
            this.TenDangNhapAdminGroupBox.Controls.Add(this.TenDangNhapAdminSubTextbox);
            this.TenDangNhapAdminGroupBox.Location = new System.Drawing.Point(68, 76);
            this.TenDangNhapAdminGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.TenDangNhapAdminGroupBox.Name = "TenDangNhapAdminGroupBox";
            this.TenDangNhapAdminGroupBox.Padding = new System.Windows.Forms.Padding(0);
            this.TenDangNhapAdminGroupBox.Size = new System.Drawing.Size(365, 58);
            this.TenDangNhapAdminGroupBox.TabIndex = 3;
            this.TenDangNhapAdminGroupBox.TabStop = false;
            // 
            // TenDangNhapAdminSubTextbox
            // 
            this.TenDangNhapAdminSubTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TenDangNhapAdminSubTextbox.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.TenDangNhapAdminSubTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TenDangNhapAdminSubTextbox.Location = new System.Drawing.Point(9, 22);
            this.TenDangNhapAdminSubTextbox.Margin = new System.Windows.Forms.Padding(9);
            this.TenDangNhapAdminSubTextbox.Name = "TenDangNhapAdminSubTextbox";
            this.TenDangNhapAdminSubTextbox.Size = new System.Drawing.Size(340, 14);
            this.TenDangNhapAdminSubTextbox.TabIndex = 2;
            this.TenDangNhapAdminSubTextbox.Text = "Tên đăng nhập";
            this.TenDangNhapAdminSubTextbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TenDangNhapAdminSubTextbox_MouseClick);
            this.TenDangNhapAdminSubTextbox.MouseLeave += new System.EventHandler(this.TenDangNhapAdminSubTextbox_MouseLeave);
            // 
            // ThemTaiKhoanAdminLable
            // 
            this.ThemTaiKhoanAdminLable.AutoSize = true;
            this.ThemTaiKhoanAdminLable.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ThemTaiKhoanAdminLable.Location = new System.Drawing.Point(24, 19);
            this.ThemTaiKhoanAdminLable.Name = "ThemTaiKhoanAdminLable";
            this.ThemTaiKhoanAdminLable.Size = new System.Drawing.Size(155, 28);
            this.ThemTaiKhoanAdminLable.TabIndex = 0;
            this.ThemTaiKhoanAdminLable.Text = "Thêm tài khoản";
            // 
            // ThemTaiKhoanAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(94)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1087, 641);
            this.Controls.Add(this.ThemTaiKhoanAdminPanel);
            this.Name = "ThemTaiKhoanAdmin";
            this.Text = "Thêm tài khoản";
            this.ThemTaiKhoanAdminPanel.ResumeLayout(false);
            this.ThemTaiKhoanAdminPanel.PerformLayout();
            this.TenDangNhapAdminGroupBox.ResumeLayout(false);
            this.TenDangNhapAdminGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ThemTaiKhoanAdminPanel;
        private Label ThemTaiKhoanAdminLable;
        private TextBox TenDangNhapAdminSubTextbox;
        private GroupBox TenDangNhapAdminGroupBox;
    }
}