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
        AccommodationManagement accommodationManagement;
        Accommodation accommodation;
        public AdminForm()
        {
            InitializeComponent();
            cbCountry.DataSource = Enum.GetValues(typeof(Places));
            admin = new Admin();
            accommodationManagement = new AccommodationManagement();
        }
        public void RefreshListBox()
        {
            listBoxAccommodation.Items.Clear();
            foreach (var accommodation in accommodationManagement.GetAccommodations())
            {
                listBoxAccommodation.Items.Add(accommodation.GetInfo());
            }
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

            accommodationManagement.CreateNewAccomodation(name, ppn, city, (Places)cbCountry.SelectedItem);
            RefreshListBox();
            
        }

        private void btnRemoveAccomodation_Click(object sender, EventArgs e)
        {
            int index = listBoxAccommodation.SelectedIndex;
            if (index != -1)
            {
                accommodationManagement.RemoveAccommodation(index);

                listBoxAccommodation.Items.Clear();

                foreach (var i in accommodationManagement.GetAccommodations())
                {
                    listBoxAccommodation.Items.Add(i.GetInfo());
                }
            }
            else
                MessageBox.Show("Error");
        }
    }
}
