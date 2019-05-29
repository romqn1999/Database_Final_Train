using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_CSDL_Train
{
    public partial class SinhVien : Form
    {
        static public DBUtils database;        

        public SinhVien(string mssv, string pass)
        {
            InitializeComponent();
            database = form_Login.database;

            DataTable dataStudent = database.Query("select * from SINHVIEN where mssv = @mssv",
                new Object[,] { { "@mssv", mssv } });

            string name = dataStudent.Rows[0][1].ToString();
            string birth = dataStudent.Rows[0][2].ToString();
            string birthPlace = dataStudent.Rows[0][3].ToString();           

            tb_Mssv.Text = mssv;
            tb_HoTen.Text = name;
            tb_NgaySinh.Text = birth;
            tb_QueQuan.Text = birthPlace;
            tb_MatKhau.Text = pass;
        }

        private void tabPage_Edit_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_DangKy_Click(object sender, EventArgs e)
        {

        }

        private void SinhVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
