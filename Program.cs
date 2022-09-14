using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Threading.Tasks;
using travelbook;
using System.Globalization;

namespace Travelbooking
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Filelines = File.ReadAllLines(@"C:\Travel Agency Offers1.tsv");

            List<Hotel>TripList = new List<Hotel>();


            foreach (var line in Filelines ) 
            {
                var recordArray = line.Split('\t');
                Hotel hotel = new Hotel(recordArray[0],recordArray[1],recordArray[2],recordArray[3],recordArray[7]);
                TripList.Add(hotel);
                
            }


            Console.WriteLine("Welcome to TravelBooking");

            Console.WriteLine("Enter Your Desired Travel Continent/Country:");


            string userinput = Console.ReadLine();
            var splitString = userinput.Split('=');
            string userinputvalidate = splitString[0];
            string userinputdata = splitString[1];


            //Console.WriteLine(userinputvalidate);
            //Console.WriteLine(userinputdata);
            if(userinputvalidate == "Continent")
            {
                var continentSpecificHotels = TripList.Where(r => r.Continent == userinputdata);
                if (continentSpecificHotels.Count() != 0)
                {
                   // Console.WriteLine("data exists");
                    int continentcount = continentSpecificHotels.Count();
                    Console.WriteLine("Result For Continent= "+userinputdata+" ("+continentcount+")");
                    int displaycount = 0;
                    foreach (var Data in continentSpecificHotels)
                    {
                        Console.WriteLine("Continent: "+Data.Continent);
                        Console.WriteLine("Country: " + Data.Country);
                        Console.WriteLine("City: " + Data.City);
                        Console.WriteLine("Hotel Name: " + Data.HotelName);
                        Console.WriteLine("Price: " + Data.Price);
                        displaycount++;
                        if (displaycount < continentcount)
                        {
                            Console.WriteLine("----------------------------------------------------------------------------------------------");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("No records found");
                }
            }
            else if(userinputvalidate == "Country")
            {
                var countrySpecificHotels = TripList.Where(r => r.Country == userinputdata);
                if (countrySpecificHotels != null)
                {
                   // Console.WriteLine("data exists");
                    int countrycount = countrySpecificHotels.Count();
                    Console.WriteLine("Result For Country= " + userinputdata + " (" + countrycount + ")");
                    int displaycount = 0;
                    foreach (var Data in countrySpecificHotels)
                    {
                        Console.WriteLine("Continent: " + Data.Continent);
                        Console.WriteLine("Country: " + Data.Country);
                        Console.WriteLine("City: " + Data.City);
                        Console.WriteLine("Hotel Name: " + Data.HotelName);
                        Console.WriteLine("Price: " + Data.Price);
                        displaycount++;
                        if (displaycount < countrycount)
                        {
                            Console.WriteLine("----------------------------------------------------------------------------------------------");
                        }

                    }
                }
                else
                {
                    Console.WriteLine("No records found");
                }
            }
            else
            {
                Console.WriteLine("Incorrect Query");
            }





            
          
        }
    }
}