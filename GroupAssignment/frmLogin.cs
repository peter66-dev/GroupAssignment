using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GroupAssignment;
using Microsoft.Extensions.Configuration;

namespace WinformPetStore
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public bool isLogin { private set; get; }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            var admin = Program.Configuration.GetSection("AdminAccount").Get<DefaultAccountSettings>();
            string adminEmail = admin.username;
            string adminPassword = admin.password;

            if(adminEmail.Equals(email) && adminPassword.Equals(password))
            {
                isLogin = true;
            }
            else
            {
                txtEmail.Text = String.Empty;
                txtPassword.Text = String.Empty;
                MessageBox.Show("Wrong username and password. Please try again!!!", "Warning");
            }
        }

    }

    public class DefaultAccountSettings
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
