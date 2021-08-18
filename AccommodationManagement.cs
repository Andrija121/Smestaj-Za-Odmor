﻿using System;
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

        public void RemoveAccommodation(int aIndex)
        {
            accommodations.RemoveAt(aIndex);
        }
        public void RemoveReservedAccommodations(int aIndex)
        {
            reservations.RemoveAt(aIndex);
        }
        public List<Accommodation> GetAccommodations()
        {
            return accommodations;
        }

        public void MakeReservation(Reservation reservation)
        {
           reservations.Add(reservation);
        }
        public List<Reservation> GetReservations()
        {
            return reservations;
        }
        public bool CheckIfReserved(Accommodation accommodation, DateTime startDate,DateTime endDate)
        {


            foreach (var r in reservations)
            {
                if (startDate>endDate )
                {
                    return true;
                }

            }
                return false;

            //todo napravi logiku da prodjes kroz listu rezervaciju i proveri da li je slobodno


        }
    }
}
