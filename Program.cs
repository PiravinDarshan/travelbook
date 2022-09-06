using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Threading.Tasks;

namespace Travelbooking
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Filelines = File.ReadAllLines(@"C:\\Travel Agency Offers.tsv\");

            List<Hotel> Hotels = new List<Hotel>();

            foreach (var line in Filelines)
            {
                var recordArray = line.Split('\t');

                Hotel hotel = new Hotel(recordArray[0], recordArray[1], recordArray[2], recordArray[3], recordArray[7]);

                Hotels.Add(hotel);
            }
            Console.WriteLine("Continent=");

            string? Continent = Console.ReadLine();

            Console.Write("thanks");
        }
    }
}