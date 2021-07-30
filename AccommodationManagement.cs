using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakOdmor
{
    public class AccommodationManagement
    {
        private static List<Accommodation> accommodations = new List<Accommodation>();
        private static List<Reservation> reservations = new List<Reservation>();



        public void CreateNewAccomodation(Accommodation accommodation)
        {
            accommodations.Add(accommodation);
        }

        //cemu ovo sluzi? primi vrednost i vrati je nazad
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

        public void MakeReservation(Reservation reservation)
        {
           reservations.Add(reservation);
        }
        public bool CheckIfReserved(Accommodation accommodation, DateTime startDate,DateTime endDate)
        {
            //napravi logiku da prodjes kroz listu rezervaciju i proveri da li je slobodno

            return true;
        }

        //razmisli jos da li je potreban ovaj status 
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
