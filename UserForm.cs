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
    public partial class UserForm : Form
    {
        AccommodationManagement accommodationManagement;


        public UserForm()
        {
            InitializeComponent();
            accommodationManagement = new AccommodationManagement();
            

        }
        public void RefreshListBox()
        {
            lbAvailableAccommodations.Items.Clear();
            foreach (var am in accommodationManagement.GetAccommodations())
            {
                lbAvailableAccommodations.Items.Add(am);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            RefreshListBox();
            cbConutry.DataSource = Enum.GetValues(typeof(Places));
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            
             
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void rbLess50_CheckedChanged(object sender, EventArgs e){

            if (rbLess50.Checked)
            {
                lbAvailableAccommodations.Items.Clear();
                foreach (var acc in accommodationManagement.GetAccommodations())
                {

                    if (acc.PricePerNight < 50)
                    {
                        lbAvailableAccommodations.Items.Add(acc);
                  }
                }

            }
        }

        private void rbLess100more50_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLess100more50.Checked)
            {
                lbAvailableAccommodations.Items.Clear();
                foreach (var acc in accommodationManagement.GetAccommodations())
                {

                    if (acc.PricePerNight >= 50 && acc.PricePerNight <= 100)
                    {
                        lbAvailableAccommodations.Items.Add(acc);
                    }
                }
            }
        }

        private void rb100plus_CheckedChanged(object sender, EventArgs e)
        {
            if (rb100plus.Checked)
            {
                lbAvailableAccommodations.Items.Clear();
                foreach (var acc in accommodationManagement.GetAccommodations())
                {

                    if (acc.PricePerNight > 100)
                    {
                        lbAvailableAccommodations.Items.Add(acc);
                    }
                }
            }
        }

        private void cbConutry_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAvailableAccommodations.Items.Clear();
            if (cbConutry.Text != "")
            {
                foreach (var acc in accommodationManagement.GetAccommodations())
                {
                    if (acc.Country.Equals((Places) cbConutry.SelectedValue))
                    {

                        lbAvailableAccommodations.Items.Add(acc);
                    }


                }
            }
        }

        private void btnReserve_Click(object sender, EventArgs e)
       
        {

            DateTime startDate= dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            if(startDate>endDate)
            {
                MessageBox.Show("Please Select Valid Dates");

            }

            Accommodation accommodation = new Accommodation();

            accommodation.StartDate = startDate;
            accommodation.EndDate = endDate;
            //opet radis petlju kad treba da izvrsis akciju na jednom objektu. Cak i da ovo radi, nema puno smisla da prolazis kroz ceo niz
            foreach (var item in accommodationManagement.GetAccommodations())
            {
                accommodationManagement.ChangeAccommodationStatus(lbAvailableAccommodations.SelectedIndex, AccommodationInfo.Reserved);
                //accommodationManagement.MakeAccommodationReserved(item);
            }
            
        }
    }
}
