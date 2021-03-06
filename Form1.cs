using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadatakOdmor
{
    public partial class Form1 : Form
    {
        Admin admin;
        User user;
        UserManagement userManagement;
        public Form1()
        {
            InitializeComponent();
            admin = new Admin();
            user = new User();
            userManagement = new UserManagement();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string userName = tbUserName.Text;
            string password = tbPassword.Text;
            if (admin.Username == userName && admin.Password == password)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();


            }
            else
            foreach (var u in userManagement.GetUsers())
            {
                if(u.Username==userName && u.Password==password)
                {
                    UserForm userForm = new UserForm();
                    userForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong username or passowrd");
                }
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
