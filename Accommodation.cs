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

        public string NameOfAccomodation { get; }
        public int PricePerNight { get; }
        public string City { get; }
        public int ID { get }
        public Places Country { get; }


        public override string ToString()
        {
            return NameOfAccomodation + " , " + PricePerNight + " , " + City + " , " + Country;
        }
    }
}