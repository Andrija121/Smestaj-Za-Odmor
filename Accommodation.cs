using System;

namespace ZadatakOdmor
{
    public class Accommodation
    {
        public Accommodation(string nameOfAccommodation, int pricePerNight, string city, Places places)
        {
            NameOfAccomodation = nameOfAccommodation;
            PricePerNight = pricePerNight;
            City = city;
            Country = places;
        }

        public Accommodation(string nameOfAccommodation, int pricePerNight, string city, Places places,
            DateTime startDate, DateTime endDate)
        {
            NameOfAccomodation = nameOfAccommodation;
            PricePerNight = pricePerNight;
            City = city;
            Country = places;
            StartDate = startDate;
            EndDate = endDate;
        }

        public Accommodation()
        {
        }

        public string NameOfAccomodation { get; }
        public int PricePerNight { get; }
        public string City { get; }
        public int ID { get; }
        public Places Country { get; }
        //ova tri property-ja bas nemaju smisla. Ako ja rezervisem smestaj u avgustu a ti u julu koji je start date a koji end date
        //koji je status ako neko zeli da zakazes u septembru
        public AccommodationInfo InfoEnum { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public override string ToString()
        {
            return NameOfAccomodation + " , " + PricePerNight + " , " + City + " , " + Country;
        }

    }
}