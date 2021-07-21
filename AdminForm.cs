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
    public partial class AdminForm : Form
    {
        Admin admin;
        public AdminForm()
        {
            InitializeComponent();
            cbCountry.DataSource = Enum.GetValues(typeof(Places));
            admin = new Admin();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnAddNewAccomodation_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            int ppn = Convert.ToInt32(tbPPN.Text);
            string city = tbTown.Text;


            admin.CreateNewAccomadtion(name, ppn, city, (Places)cbCountry.SelectedItem);
            
            

            
        }
    }
}
