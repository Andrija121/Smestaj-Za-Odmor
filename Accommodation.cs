﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakOdmor
{
    class Accommodation
    {
        public string NameOfAccomodation { get; }
        public int PricePerNight { get; }
        public string City { get; }
        public Places Country { get; }
        public AccommodationInfo InfoEnum { get; set; }

        public Accommodation(string nameOfAccommodation,int pricePerNight,string city,Places places)
        {
            NameOfAccomodation = nameOfAccommodation;
            PricePerNight = pricePerNight;
            City = city;
            Country = places;

        }

        public Accommodation()
        {
        }

        public string GetInfo()
        {
            return NameOfAccomodation + " , " + PricePerNight + " , " + City + " , " + Country.ToString();
        }


    }
}
