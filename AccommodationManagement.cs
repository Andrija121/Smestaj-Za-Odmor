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
        private static List<Accommodation> reservedAccommodations = new List<Accommodation>();



        public void CreateNewAccomodation(string name, int ppn, string city, Places places)
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
        public List<Accommodation> GetReservedAccommodations()
        {
            return reservedAccommodations;
        }
        public void MakeAccommodationReserved(Accommodation accommodation)
        {
            accommodations.Remove(accommodation);
            reservedAccommodations.Add(accommodation);
        }
        public bool CheckIfReserved(DateTime startDate,DateTime endDate)
        {
            if (accommodation.StartDate < accommodation.EndDate)
                return true;
            else return false;
        }
        public void ChangeAccommodationStatus(int index,AccommodationInfo accommodationInfo)
        {
            foreach (var item in accommodations)
            {
                if(item.ID==index)
                {
                    item.InfoEnum = accommodationInfo;
                }
            }
        }

    }
}
