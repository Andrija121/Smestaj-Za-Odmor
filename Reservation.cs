using System;

namespace ZadatakOdmor
{
    // svrha ove klase je da cuva informacije o smestaju, periodu u kojem je rezervisan i koji user je reservisao.
    // kada se proverava da li je smestaj dostupan i da li treba da se prikaze na listi, trebalo bi proveriti kolekciju rezervacija i 
    // proveriti da li je odgovarajuci smestaj dostupan u tom terminu
    // ako imas bolju ideju slobodno implementiraj
    
    public class Reservation
    {
        public Reservation(Accommodation accommodation, DateTime startDate, DateTime endDate, string reservedBy)
        {
            Accommodation = accommodation;
            StartDate = startDate;
            EndDate = endDate;
            ReservedBy = reservedBy;
        }

        public Accommodation Accommodation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ReservedBy { get; set; }

        public string GetInfo()
        {
            return Accommodation + " - " + StartDate + " - " + EndDate + " - " + ReservedBy;
        }
    }
}