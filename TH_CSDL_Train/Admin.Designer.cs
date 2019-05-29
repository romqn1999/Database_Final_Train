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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv_SinhVien = new System.Windows.Forms.DataGridView();
            this.btn_XOa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgv_MonHoc = new System.Windows.Forms.DataGridView();
            this.tb_MonHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_LopHoc = new System.Windows.Forms.DataGridView();
            this.tb_LopHoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_HocPhan = new System.Windows.Forms.DataGridView();
            this.tb_HocPhan_MaMon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_SinhVien.SuspendLayout();
            this.tabPage_MonHoc.SuspendLayout();
            this.tabPage_LopHoc.SuspendLayout();
            this.tabPage_HocPhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LopHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocPhan)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(772, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_SinhVien
            // 
            this.tabPage_SinhVien.Controls.Add(this.button3);
            this.tabPage_SinhVien.Controls.Add(this.button2);
            this.tabPage_SinhVien.Controls.Add(this.btn_XOa);
            this.tabPage_SinhVien.Controls.Add(this.dgv_SinhVien);
            this.tabPage_SinhVien.Controls.Add(this.textBox1);
            this.tabPage_SinhVien.Controls.Add(this.label1);
            this.tabPage_SinhVien.Location = new System.Drawing.Point(4, 34);
            this.tabPage_SinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_SinhVien.Name = "tabPage_SinhVien";
            this.tabPage_SinhVien.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_SinhVien.Size = new System.Drawing.Size(764, 417);
            this.tabPage_SinhVien.TabIndex = 0;
            this.tabPage_SinhVien.Text = "Sinh viên";
            this.tabPage_SinhVien.UseVisualStyleBackColor = true;
            // 
            // tabPage_MonHoc
            // 
            this.tabPage_MonHoc.Controls.Add(this.dgv_MonHoc);
            this.tabPage_MonHoc.Controls.Add(this.tb_MonHoc);
            this.tabPage_MonHoc.Controls.Add(this.label2);
            this.tabPage_MonHoc.Location = new System.Drawing.Point(4, 34);
            this.tabPage_MonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_MonHoc.Name = "tabPage_MonHoc";
            this.tabPage_MonHoc.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_MonHoc.Size = new System.Drawing.Size(764, 417);
            this.tabPage_MonHoc.TabIndex = 1;
            this.tabPage_MonHoc.Text = "Môn học";
            this.tabPage_MonHoc.UseVisualStyleBackColor = true;
            // 
            // tabPage_LopHoc
            // 
            this.tabPage_LopHoc.Controls.Add(this.dgv_LopHoc);
            this.tabPage_LopHoc.Controls.Add(this.tb_LopHoc);
            this.tabPage_LopHoc.Controls.Add(this.label3);
            this.tabPage_LopHoc.Location = new System.Drawing.Point(4, 34);
            this.tabPage_LopHoc.Name = "tabPage_LopHoc";
            this.tabPage_LopHoc.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_LopHoc.Size = new System.Drawing.Size(764, 417);
            this.tabPage_LopHoc.TabIndex = 2;
            this.tabPage_LopHoc.Text = "Lớp học";
            this.tabPage_LopHoc.UseVisualStyleBackColor = true;
            // 
            // tabPage_HocPhan
            // 
            this.tabPage_HocPhan.Controls.Add(this.dgv_HocPhan);
            this.tabPage_HocPhan.Controls.Add(this.tb_HocPhan_MaMon);
            this.tabPage_HocPhan.Controls.Add(this.label4);
            this.tabPage_HocPhan.Location = new System.Drawing.Point(4, 34);
            this.tabPage_HocPhan.Name = "tabPage_HocPhan";
            this.tabPage_HocPhan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_HocPhan.Size = new System.Drawing.Size(764, 417);
            this.tabPage_HocPhan.TabIndex = 3;
            this.tabPage_HocPhan.Text = "Học phần";
            this.tabPage_HocPhan.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số sinh viên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(578, 30);
            this.textBox1.TabIndex = 1;
            // 
            // dgv_SinhVien
            // 
            this.dgv_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SinhVien.Location = new System.Drawing.Point(8, 61);
            this.dgv_SinhVien.Name = "dgv_SinhVien";
            this.dgv_SinhVien.RowTemplate.Height = 28;
            this.dgv_SinhVien.Size = new System.Drawing.Size(740, 270);
            this.dgv_SinhVien.TabIndex = 2;
            // 
            // btn_XOa
            // 
            this.btn_XOa.Location = new System.Drawing.Point(7, 351);
            this.btn_XOa.Name = "btn_XOa";
            this.btn_XOa.Size = new System.Drawing.Size(152, 47);
            this.btn_XOa.TabIndex = 3;
            this.btn_XOa.Text = "button1";
            this.btn_XOa.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(596, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgv_MonHoc
            // 
            this.dgv_MonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MonHoc.Location = new System.Drawing.Point(17, 70);
            this.dgv_MonHoc.Name = "dgv_MonHoc";
            this.dgv_MonHoc.RowTemplate.Height = 28;
            this.dgv_MonHoc.Size = new System.Drawing.Size(740, 270);
            this.dgv_MonHoc.TabIndex = 5;
            // 
            // tb_MonHoc
            // 
            this.tb_MonHoc.Location = new System.Drawing.Point(179, 17);
            this.tb_MonHoc.Name = "tb_MonHoc";
            this.tb_MonHoc.Size = new System.Drawing.Size(578, 30);
            this.tb_MonHoc.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã số môn học";
            // 
            // dgv_LopHoc
            // 
            this.dgv_LopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LopHoc.Location = new System.Drawing.Point(18, 79);
            this.dgv_LopHoc.Name = "dgv_LopHoc";
            this.dgv_LopHoc.RowTemplate.Height = 28;
            this.dgv_LopHoc.Size = new System.Drawing.Size(740, 270);
            this.dgv_LopHoc.TabIndex = 5;
            // 
            // tb_LopHoc
            // 
            this.tb_LopHoc.Location = new System.Drawing.Point(180, 26);
            this.tb_LopHoc.Name = "tb_LopHoc";
            this.tb_LopHoc.Size = new System.Drawing.Size(578, 30);
            this.tb_LopHoc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã lớp học";
            // 
            // dgv_HocPhan
            // 
            this.dgv_HocPhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HocPhan.Location = new System.Drawing.Point(18, 76);
            this.dgv_HocPhan.Name = "dgv_HocPhan";
            this.dgv_HocPhan.RowTemplate.Height = 28;
            this.dgv_HocPhan.Size = new System.Drawing.Size(740, 270);
            this.dgv_HocPhan.TabIndex = 5;
            // 
            // tb_HocPhan_MaMon
            // 
            this.tb_HocPhan_MaMon.Location = new System.Drawing.Point(180, 23);
            this.tb_HocPhan_MaMon.Name = "tb_HocPhan_MaMon";
            this.tb_HocPhan_MaMon.Size = new System.Drawing.Size(578, 30);
            this.tb_HocPhan_MaMon.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã môn học";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 470);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin";
            this.Text = "Admin";
            this.tabControl1.ResumeLayout(false);
            this.tabPage_SinhVien.ResumeLayout(false);
            this.tabPage_SinhVien.PerformLayout();
            this.tabPage_MonHoc.ResumeLayout(false);
            this.tabPage_MonHoc.PerformLayout();
            this.tabPage_LopHoc.ResumeLayout(false);
            this.tabPage_LopHoc.PerformLayout();
            this.tabPage_HocPhan.ResumeLayout(false);
            this.tabPage_HocPhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LopHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HocPhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_SinhVien;
        private System.Windows.Forms.TabPage tabPage_MonHoc;
        private System.Windows.Forms.TabPage tabPage_LopHoc;
        private System.Windows.Forms.TabPage tabPage_HocPhan;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_XOa;
        private System.Windows.Forms.DataGridView dgv_SinhVien;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_MonHoc;
        private System.Windows.Forms.TextBox tb_MonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_LopHoc;
        private System.Windows.Forms.TextBox tb_LopHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_HocPhan;
        private System.Windows.Forms.TextBox tb_HocPhan_MaMon;
        private System.Windows.Forms.Label label4;
    }
}