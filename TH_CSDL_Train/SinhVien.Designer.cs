namespace TH_CSDL_Train
{
    partial class SinhVien
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
            this.tabPage_Edit = new System.Windows.Forms.TabPage();
            this.tabPage_DangKy = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Mssv = new System.Windows.Forms.TextBox();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.tb_NgaySinh = new System.Windows.Forms.TextBox();
            this.tb_QueQuan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_DangKy = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage_Edit.SuspendLayout();
            this.tabPage_DangKy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_Edit);
            this.tabControl1.Controls.Add(this.tabPage_DangKy);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 414);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Edit
            // 
            this.tabPage_Edit.Controls.Add(this.btn_Edit);
            this.tabPage_Edit.Controls.Add(this.tb_MatKhau);
            this.tabPage_Edit.Controls.Add(this.label5);
            this.tabPage_Edit.Controls.Add(this.tb_QueQuan);
            this.tabPage_Edit.Controls.Add(this.tb_NgaySinh);
            this.tabPage_Edit.Controls.Add(this.tb_HoTen);
            this.tabPage_Edit.Controls.Add(this.tb_Mssv);
            this.tabPage_Edit.Controls.Add(this.label4);
            this.tabPage_Edit.Controls.Add(this.label3);
            this.tabPage_Edit.Controls.Add(this.label2);
            this.tabPage_Edit.Controls.Add(this.label1);
            this.tabPage_Edit.Location = new System.Drawing.Point(4, 34);
            this.tabPage_Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Edit.Name = "tabPage_Edit";
            this.tabPage_Edit.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Edit.Size = new System.Drawing.Size(786, 376);
            this.tabPage_Edit.TabIndex = 0;
            this.tabPage_Edit.Text = "Thông tin";
            this.tabPage_Edit.UseVisualStyleBackColor = true;
            this.tabPage_Edit.Click += new System.EventHandler(this.tabPage_Edit_Click);
            // 
            // tabPage_DangKy
            // 
            this.tabPage_DangKy.Controls.Add(this.btn_DangKy);
            this.tabPage_DangKy.Controls.Add(this.comboBox2);
            this.tabPage_DangKy.Controls.Add(this.comboBox1);
            this.tabPage_DangKy.Controls.Add(this.label7);
            this.tabPage_DangKy.Controls.Add(this.label6);
            this.tabPage_DangKy.Location = new System.Drawing.Point(4, 34);
            this.tabPage_DangKy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_DangKy.Name = "tabPage_DangKy";
            this.tabPage_DangKy.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_DangKy.Size = new System.Drawing.Size(786, 376);
            this.tabPage_DangKy.TabIndex = 1;
            this.tabPage_DangKy.Text = "Đăng ký học phần";
            this.tabPage_DangKy.UseVisualStyleBackColor = true;
            this.tabPage_DangKy.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quê quán";
            // 
            // tb_Mssv
            // 
            this.tb_Mssv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Mssv.Location = new System.Drawing.Point(226, 31);
            this.tb_Mssv.Name = "tb_Mssv";
            this.tb_Mssv.Size = new System.Drawing.Size(526, 30);
            this.tb_Mssv.TabIndex = 4;
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_HoTen.Location = new System.Drawing.Point(226, 80);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(526, 30);
            this.tb_HoTen.TabIndex = 5;
            // 
            // tb_NgaySinh
            // 
            this.tb_NgaySinh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_NgaySinh.Location = new System.Drawing.Point(226, 138);
            this.tb_NgaySinh.Name = "tb_NgaySinh";
            this.tb_NgaySinh.Size = new System.Drawing.Size(526, 30);
            this.tb_NgaySinh.TabIndex = 6;
            // 
            // tb_QueQuan
            // 
            this.tb_QueQuan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_QueQuan.Location = new System.Drawing.Point(226, 190);
            this.tb_QueQuan.Name = "tb_QueQuan";
            this.tb_QueQuan.Size = new System.Drawing.Size(526, 30);
            this.tb_QueQuan.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mật khẩu";
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_MatKhau.Location = new System.Drawing.Point(226, 247);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.PasswordChar = '*';
            this.tb_MatKhau.Size = new System.Drawing.Size(526, 30);
            this.tb_MatKhau.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Môn học";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Lớp học";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(572, 33);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(186, 184);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(572, 33);
            this.comboBox2.TabIndex = 7;
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(226, 305);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(298, 55);
            this.btn_Edit.TabIndex = 10;
            this.btn_Edit.Text = "Chỉnh sửa";
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_DangKy
            // 
            this.btn_DangKy.Location = new System.Drawing.Point(238, 257);
            this.btn_DangKy.Name = "btn_DangKy";
            this.btn_DangKy.Size = new System.Drawing.Size(292, 55);
            this.btn_DangKy.TabIndex = 8;
            this.btn_DangKy.Text = "Đăng ký";
            this.btn_DangKy.UseVisualStyleBackColor = true;
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 418);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SinhVien";
            this.Text = "SinhVien";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Edit.ResumeLayout(false);
            this.tabPage_Edit.PerformLayout();
            this.tabPage_DangKy.ResumeLayout(false);
            this.tabPage_DangKy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Edit;
        private System.Windows.Forms.TabPage tabPage_DangKy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_MatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_QueQuan;
        private System.Windows.Forms.TextBox tb_NgaySinh;
        private System.Windows.Forms.TextBox tb_HoTen;
        private System.Windows.Forms.TextBox tb_Mssv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_DangKy;
    }
}