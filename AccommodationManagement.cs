using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakOdmor
{
    class AccommodationManagement
    {
        Accommodation accommodation;
        private static List<Accommodation> accommodations = new List<Accommodation>();



        public void CreateNewAccomodation(string name,int ppn,string city,Places places)
        {
            accommodation = new Accommodation(name, ppn, city, places);
            accommodations.Add(accommodation);
        }
        public int getPrice(int ppn)
        {
            return ppn;
        }
        public void RemoveAccommodation(int aIndex)
        {
            accommodations.RemoveAt(aIndex);
        }
        public List<Accommodation> GetAccommodations()
        {
            return accommodations;
        }

    }
}
