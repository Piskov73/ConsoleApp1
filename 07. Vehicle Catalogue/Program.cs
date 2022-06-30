using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Transport
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int WeightPower { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Transport> catalogueCars = new List<Transport>();
            List<Transport> catalogueTrucks = new List<Transport>();
            string[] inputTransport = Console.ReadLine().Split('/', StringSplitOptions.RemoveEmptyEntries);
            while (inputTransport[0] != "end")
            {

                string type = inputTransport[0];
                string brand = inputTransport[1];
                string model = inputTransport[2];
                int weightPower = int.Parse(inputTransport[3]);
                if (type == "Car")
                {
                    Transport cars = new Transport();
                    cars.Brand = brand;
                    cars.Model = model;
                    cars.WeightPower = weightPower;
                    catalogueCars.Add(cars);
                }
                if (type == "Truck")
                {
                    Transport truck = new Transport();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.WeightPower = weightPower;
                    catalogueTrucks.Add(truck);
                }
                inputTransport = Console.ReadLine().Split('/', StringSplitOptions.RemoveEmptyEntries);
            }
            List<Transport> filterCars = catalogueCars.OrderBy(cars => cars.Brand).ToList();
            List<Transport> filyerTruck = catalogueTrucks.OrderBy(truk => truk.Brand).ToList();


            if (filterCars.Count != 0)
            {
               

                Console.WriteLine("Cars:");

                foreach (var car in filterCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - { car.WeightPower}hp");
                }
            }
            if (filyerTruck.Count != 0)
            {

                Console.WriteLine("Trucks:");
                foreach (var truck in filyerTruck)
                {
                    Console.WriteLine($"{ truck.Brand}: { truck.Model} - { truck.WeightPower}kg");
                }
            }
         




        }
    }
}
