using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Threading.Tasks;
using travelbook;

namespace Travelbooking
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Filelines = File.ReadAllLines(@"C:\Travel Agency Offers.tsv");

            List<Hotel>Hotels = new List<Hotel>();

            List<Hotel>Countries = new List<Hotel>(); 

            foreach (var line in Filelines ) 
            {
                var recordArray = line.Split('\t');
                //Console.WriteLine(recordArray[0] );
                //Console.WriteLine(recordArray[1]);
                //Console.WriteLine(recordArray[2]);
                //Console.WriteLine(recordArray[3]);
                //Console.WriteLine(recordArray[7]);
                Hotel hotel = new Hotel(recordArray[0],recordArray[1],recordArray[2],recordArray[3],recordArray[7]);
                Hotels.Add(hotel);
                Hotel country = new Hotel(recordArray[0], recordArray[1], recordArray[2], recordArray[3], recordArray[7]);
                Countries.Add(country);
            }


            //var asianHotels = Hotels.Where(x => x.Continent.Equals("Asia"));

            //var europeanHotels = Hotels.Where(x => x.Continent.Equals("Europe"));

            Console.WriteLine("Enter Continent:");

            string Continent = Console.ReadLine();

            var asianCountries =  Countries.Where(x => x.Continent.Equals("Asia"));

            var europeanCountries = Countries.Where(x => x.Continent.Equals("Europe"));

            Console.WriteLine("List Of Countries:");

            
            foreach (var country in asianCountries)
            {
               
                Console.WriteLine(country.Country);
                
               
            }

            foreach (var country in europeanCountries)
            {
                Console.WriteLine(country.Country);
            }




            //foreach (var hotel in asianHotels)
            //{
            //    Console.WriteLine(hotel.HotelName);
            //}

            //foreach (var hotel in europeanHotels)
            //{
            //    Console.WriteLine(hotel.HotelName);
            //}
        }
    }
}