using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelbooking
{

    public class Hotel
    {
        public string Continent { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string HotelName { get; set; }
        public string Price { get; set; }

        public Hotel(string continent, string country, string city, string hotelName, string price);
        
        {

        this.Continent = continent;
        this.Country = country;
        this.City = city;
        this.HotelName = hotelName;
        this.Price = Convert.ToDouble(price);

        }


}
}
}