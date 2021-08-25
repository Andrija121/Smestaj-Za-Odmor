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
    public partial class SignUp : Form
    {
        UserManagement userManagement;
        public SignUp()
        {
            InitializeComponent();
            userManagement = new UserManagement();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            
            string username = tbUserName.Text;
            string password = tbPassword.Text;
            User user = new User(username, password);
            userManagement.AddUser(user);
            
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
}
