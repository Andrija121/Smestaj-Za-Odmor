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
        public bool CheckIfAvailable(Accommodation accommodation, DateTime startDate,DateTime endDate)
        {
            foreach (var r in reservations)
            {
                if (r.Accommodation == accommodation)
                {
                    if (startDate >= r.StartDate && startDate < r.EndDate)
                    {
                        return false;
                    }

                    if (endDate > r.StartDate && endDate <= r.EndDate)
                    {
                        return false;
                    }

                    if (startDate <= r.StartDate && endDate >= r.EndDate)
                    {
                        return false;
                    }
                }
            }

            return true;


        }
                

            //todo napravi logiku da prodjes kroz listu rezervaciju i proveri da li je slobodno //done


        }
    }

