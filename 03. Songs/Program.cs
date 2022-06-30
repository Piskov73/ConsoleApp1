using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Sonds
    {
        //•	Type List
        //•	Name
        //•	Time
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Sonds> pleyList = new List<Sonds>();
            int numbPleyList = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbPleyList; i++)
            {
                string[] newSong = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries);
                Sonds song = new Sonds();
                song.TypeList = newSong[0];
                song.Name = newSong[1];
                song.Time = newSong[2];
                pleyList.Add(song);

            }
            string comand = Console.ReadLine();
            if (comand == "all")
            {
                foreach (var song in pleyList)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Sonds> filterList = new List<Sonds>();
                foreach (var song in pleyList)
                {
                    if (song.TypeList == comand)
                    {
                        filterList.Add(song);
                    }
                   
                }
                foreach (var song in filterList)
                {
                    Console.WriteLine(song.Name);
                }
            }

        }
    }
}
