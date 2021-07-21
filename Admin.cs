using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakOdmor
{
    class Admin
    {
        private Accommodation accommodation;
        private string username = "admin";
        private string password = "admin";


        private string nameOfAccomadtion;
        private int pricePerNight;
        private string city;
        private Places places;

        public string NameOfAccomadtion { get { return nameOfAccomadtion; } }
        public int PricePerNight { get { return pricePerNight; } }
        public string City { get { return city; } }
        public Places Conutry { get; private set; }
        public string Username { get { return username; } }
        public string Password { get { return password; } }



        public Admin()
        {
            this.nameOfAccomadtion = NameOfAccomadtion;
            this.pricePerNight = PricePerNight;
            this.city = City;
        }

        public void CreateNewAccomadtion(string nameOfAccomadtion, int ppn, string city, Places place)
        {
            accommodation.MakeNewAccomodation(nameOfAccomadtion, ppn, city, place);
        }
    }
}
