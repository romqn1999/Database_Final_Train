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
    public partial class form_Login : Form
    {
        static public DBUtils database;

        public form_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = DESKTOP-4SHP37S; Initial Catalog = QLSV;
            User ID = sa; Password = tonhieu123";
            database = new DBUtils(connectionString);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = tb_Username.Text.ToString();
            string password = tb_Password.Text.ToString();

            DataTable dataTable = database.Query("select * from TAIKHOAN where id = @id and pass = @pass",
                new Object[,] { { "@id", username }, { "@pass", password } });

            if (dataTable.Rows.Count == 1)
            {
                MessageBox.Show("Đăng nhập thành công!");

                if (username == "admin")
                {
                    Admin adminForm = new Admin();
                    adminForm.Show();
                    //this.Visible = false;
                    this.Hide();
                }
                else
                {
                    SinhVien studentForm = new SinhVien(username, password);
                    studentForm.Show();
                    //this.Visible = false;
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }
    }
}
