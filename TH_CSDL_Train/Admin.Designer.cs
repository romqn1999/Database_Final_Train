namespace TH_CSDL_Train
{
    partial class Admin
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_SinhVien = new System.Windows.Forms.TabPage();
            this.tabPage_MonHoc = new System.Windows.Forms.TabPage();
            this.tabPage_LopHoc = new System.Windows.Forms.TabPage();
            this.tabPage_HocPhan = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_SinhVien);
            this.tabControl1.Controls.Add(this.tabPage_MonHoc);
            this.tabControl1.Controls.Add(this.tabPage_LopHoc);
            this.tabControl1.Controls.Add(this.tabPage_HocPhan);
            this.tabControl1.Location = new System.Drawing.Point(1, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(763, 388);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_SinhVien
            // 
            this.tabPage_SinhVien.Location = new System.Drawing.Point(4, 34);
            this.tabPage_SinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_SinhVien.Name = "tabPage_SinhVien";
            this.tabPage_SinhVien.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_SinhVien.Size = new System.Drawing.Size(755, 350);
            this.tabPage_SinhVien.TabIndex = 0;
            this.tabPage_SinhVien.Text = "Sinh viên";
            this.tabPage_SinhVien.UseVisualStyleBackColor = true;
            // 
            // tabPage_MonHoc
            // 
            this.tabPage_MonHoc.Location = new System.Drawing.Point(4, 34);
            this.tabPage_MonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_MonHoc.Name = "tabPage_MonHoc";
            this.tabPage_MonHoc.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_MonHoc.Size = new System.Drawing.Size(755, 350);
            this.tabPage_MonHoc.TabIndex = 1;
            this.tabPage_MonHoc.Text = "Môn học";
            this.tabPage_MonHoc.UseVisualStyleBackColor = true;
            // 
            // tabPage_LopHoc
            // 
            this.tabPage_LopHoc.Location = new System.Drawing.Point(4, 34);
            this.tabPage_LopHoc.Name = "tabPage_LopHoc";
            this.tabPage_LopHoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_LopHoc.Size = new System.Drawing.Size(755, 350);
            this.tabPage_LopHoc.TabIndex = 2;
            this.tabPage_LopHoc.Text = "Lớp học";
            this.tabPage_LopHoc.UseVisualStyleBackColor = true;
            // 
            // tabPage_HocPhan
            // 
            this.tabPage_HocPhan.Location = new System.Drawing.Point(4, 34);
            this.tabPage_HocPhan.Name = "tabPage_HocPhan";
            this.tabPage_HocPhan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_HocPhan.Size = new System.Drawing.Size(755, 350);
            this.tabPage_HocPhan.TabIndex = 3;
            this.tabPage_HocPhan.Text = "Học phần";
            this.tabPage_HocPhan.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 403);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin";
            this.Text = "Admin";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_SinhVien;
        private System.Windows.Forms.TabPage tabPage_MonHoc;
        private System.Windows.Forms.TabPage tabPage_LopHoc;
        private System.Windows.Forms.TabPage tabPage_HocPhan;
    }
}