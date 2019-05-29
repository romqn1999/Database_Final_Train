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
    public partial class Admin : Form
    {
        static public DBUtils database;

        public Admin()
        {
            InitializeComponent();

            database = form_Login.database;
        }

        private void Admin_Load(object sender, EventArgs e)
        {            

        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
