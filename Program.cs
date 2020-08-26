using System;

namespace planner
{
    class Program
    {
        static void Main(string[] args)
        {
            // 512 8th Ave Building
            Building FiveOneTwoEight = new Building("512 8th Avenue");
            FiveOneTwoEight.Stories = 10;
            FiveOneTwoEight.Width = 10.5;
            FiveOneTwoEight.Depth = 10.5;
            FiveOneTwoEight.Construct("James Su");
            FiveOneTwoEight.Purchase("Bob Ross");
            FiveOneTwoEight.DisplayBuildingInfo();

            Console.WriteLine();

            // 100 Main St Building
            Building OneHundred = new Building("100 Main Street");
            OneHundred.Stories = 5;
            OneHundred.Width = 5;
            OneHundred.Depth = 5;
            OneHundred.Construct("John Doe");
            OneHundred.Purchase("Ross Bob");
            OneHundred.DisplayBuildingInfo();

            Console.WriteLine();

            // 1301 6th Ave Building
            Building ThirteenZeroOne = new Building("1301 6th Avenue");
            ThirteenZeroOne.Stories = 100;
            ThirteenZeroOne.Width = 1000.5;
            ThirteenZeroOne.Depth = 1000.2;
            ThirteenZeroOne.Construct("Jane Doe");
            ThirteenZeroOne.Purchase("Rob Boss");
            ThirteenZeroOne.DisplayBuildingInfo();

        }
    }
}