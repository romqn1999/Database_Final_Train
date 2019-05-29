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
            this.tabControl1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(794, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage_Edit
            // 
            this.tabPage_Edit.Location = new System.Drawing.Point(4, 29);
            this.tabPage_Edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Edit.Name = "tabPage_Edit";
            this.tabPage_Edit.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Edit.Size = new System.Drawing.Size(1055, 525);
            this.tabPage_Edit.TabIndex = 0;
            this.tabPage_Edit.Text = "Thông tin";
            this.tabPage_Edit.UseVisualStyleBackColor = true;
            // 
            // tabPage_DangKy
            // 
            this.tabPage_DangKy.Location = new System.Drawing.Point(4, 34);
            this.tabPage_DangKy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_DangKy.Name = "tabPage_DangKy";
            this.tabPage_DangKy.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_DangKy.Size = new System.Drawing.Size(786, 367);
            this.tabPage_DangKy.TabIndex = 1;
            this.tabPage_DangKy.Text = "Đăng ký học phần";
            this.tabPage_DangKy.UseVisualStyleBackColor = true;
            this.tabPage_DangKy.Click += new System.EventHandler(this.tabPage2_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Edit;
        private System.Windows.Forms.TabPage tabPage_DangKy;
    }
}