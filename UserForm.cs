﻿using System;
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
        Accommodation accommodation;


        public UserForm()
        {
            InitializeComponent();
            accommodationManagement = new AccommodationManagement();
            accommodation = new Accommodation();

        }
        public void RefreshListBox()
        {
            lbAvailableAccommodations.Items.Clear();
            foreach (var am in accommodationManagement.GetAccommodations())
            {
                lbAvailableAccommodations.Items.Add(am.GetInfo());
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
                        lbAvailableAccommodations.Items.Add(acc.GetInfo());
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
                        lbAvailableAccommodations.Items.Add(acc.GetInfo());
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
                        lbAvailableAccommodations.Items.Add(acc.GetInfo());
                    }
                }
            }
        }

        private void cbConutry_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAvailableAccommodations.Items.Clear();
            
            foreach (var acc in accommodationManagement.GetAccommodations())
            {
                if (acc.Country.Equals(Places.CrnaGora))
                {
                    
                    lbAvailableAccommodations.Items.Add(acc.GetInfo());
                }
                else if (acc.Country.Equals(Places.Grcka))
                {
                    
                    lbAvailableAccommodations.Items.Add(acc.GetInfo());
                }
                else if (acc.Country.Equals(Places.Hrvatska))
                {
                    
                    lbAvailableAccommodations.Items.Add(acc.GetInfo());
                }
                else if (acc.Country.Equals(Places.Turska))
                {
                    
                    lbAvailableAccommodations.Items.Add(acc.GetInfo());
                }
               
            }
        }
    }
}
