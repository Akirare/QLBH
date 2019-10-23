using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUser.Text == "admin" && txtPassword.Text == "123")
            {
                MessageBox.Show("Welcome!!!");
                FormMain frmMain = new FormMain();
                frmMain.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
     
    }
}
