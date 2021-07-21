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
        private Places places;
        private List<Accommodation> accommodations;

        public string NameOfAccomadtion { get { return nameOfAccomadtion; } }
        public int PricePerNight { get { return pricePerNight; } }
        public string City { get { return city; } }
        public Places Conutry { get; private set; }

        public Accommodation(string nameOfAccommodation,int pricePerNight,string city,Places places)
        {
            this.nameOfAccomadtion = NameOfAccomadtion;
            this.pricePerNight = PricePerNight;
            this.city = City;
            accommodations = new List<Accommodation>();
        }

        public void MakeNewAccomodation(string noa,int ppn,string city,Places place)
        {
            Accommodation accommodation = new Accommodation(noa,ppn, city, place);
            accommodations.Add(accommodation);


        }

        public bool CheckIfAccommodationAvailabe()
        {

        }
        public string GetInfo()
        {
            return NameOfAccomadtion + " , " + PricePerNight + " , " + City + " , " + places.ToString();
        }
    }
}
