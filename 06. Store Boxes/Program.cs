using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{

    class Box
    {
        //Define a class Box, which contains these properties: Serial Number, Item, Item Quantity, and Price for a Box.

        public string SerialNumber { get; set; }
        public string Name { get; set; }

        public int Quantiti { get; set; }
        public decimal PriceBox { get; set; }
        public decimal TotalPriceBox { get; set; }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string[] data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (data[0] != "end")
            {
                Box box = new Box();
                string serialNumber = data[0];
                string name = data[1];
                int quantiti = int.Parse(data[2]);
                decimal price = decimal.Parse(data[3]);
                decimal totalPrice = price * quantiti;

                box.SerialNumber = serialNumber;
                box.Name = name;
                box.Quantiti = quantiti;
                box.PriceBox = price;
                box.TotalPriceBox = totalPrice;
                boxes.Add(box);

                data = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                //: "{Serial Number} {Item Name} {Item Quantity} {itemPrice}"


            }
            //List<Box> sortedBox = boxes.OrderByDescending(boxes => boxes.TotalPrice).ToList();
            List<Box> sortiBoxes = boxes.OrderByDescending(boxes => boxes.TotalPriceBox).ToList();
            //{ boxSerialNumber}
            //-- { boxItemName} – ${ boxItemPrice}: { boxItemQuantity}
            //-- ${ boxPrice}
            foreach (Box box in sortiBoxes)
            {
                Console.WriteLine($" {box.SerialNumber}");
                Console.WriteLine($"-- { box.Name} - ${ box.PriceBox:f2}: { box.Quantiti}");
                Console.WriteLine($"-- ${ box.TotalPriceBox:f2}");
            }

        }
    }
}
