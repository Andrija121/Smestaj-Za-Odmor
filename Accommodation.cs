using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakOdmor
{
    class Accommodation
    {
        private string nameOfAccomadtion;
        private int pricePerNight;
        private string city;
        Places places;
        


        public string NameOfAccomadtion { get { return nameOfAccomadtion; } }
        public int PricePerNight { get { return pricePerNight; } }
        public string City { get { return city; } }
        public Places Conutry { get; private set; }
        public AccommodationInfo infoEnum { get; set; }

        public Accommodation(string nameOfAccommodation,int pricePerNight,string city,Places places)
        {
            this.nameOfAccomadtion = NameOfAccomadtion;
            this.pricePerNight = PricePerNight;
            this.city = City;
            
        }
        public string GetInfo()
        {
            return nameOfAccomadtion + " , " + pricePerNight+ " , " + city + " , " + places.ToString();
        }


    }
}
