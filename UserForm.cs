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
        User user;
        


        public UserForm(User user)
        {
            InitializeComponent();
            accommodationManagement = new AccommodationManagement();
            this.user = user;
           
            

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

      

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        
            //todo napraviti cenu od-do (npr. mobile.de)! //done
           
        

        

       

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

        //todo dugme za rezervaciju treba da proveri da li ima vec rezervacija tog smestaja za taj termin
        private void btnReserve_Click(object sender, EventArgs e)
      
        {
            if(lbAvailableAccommodations.SelectedIndex!=-1)
            { 
            
            DateTime startDate= dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;
            Accommodation accommodation = (Accommodation) lbAvailableAccommodations.SelectedItem;
            if(startDate <= endDate)
            {
                Reservation reservation = new Reservation(accommodation, dateTimePicker1.Value, dateTimePicker2.Value,user.Username);
                if (accommodationManagement.CheckIfAvailable(accommodation, startDate, endDate) == true)
                    {
                       
                        accommodationManagement.MakeReservation(reservation);
                        MessageBox.Show("Reservation Made Succesfully");

                    }
                    else
                        MessageBox.Show("Reservation Not Made Succesfully");
                
                
                //todo zbog ovoga je moguce samo uraditi jednu rezervaciju. Ako ti rezervises u 8 osmom mesecu, ja necu moci da rezervisem u devetom mesecu//done
                //da proverim da li su rezervisan izabrani smestaj u tom datumu//done
            }
            else if(startDate > endDate )
            {
                MessageBox.Show("Please Select Valid Dates");
            }
            }
            else
            {
                MessageBox.Show("Please select the accommodation");
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            lbAvailableAccommodations.Items.Clear();
            int minPrice = Convert.ToInt32(tbMinPrice.Text);
            int maxPrice = Convert.ToInt32(tbMaxPrice.Text);


            foreach (var a in accommodationManagement.GetAccommodations())
            {
                if(a.PricePerNight>=minPrice && a.PricePerNight<=maxPrice)
                {
                    lbAvailableAccommodations.Items.Add(a);
                }
            }
        }
    }
}
