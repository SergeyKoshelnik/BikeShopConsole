using System;

namespace BikeShopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            BikeShop bikeShop = new BikeShop();

            Helper.ReadAndWriteCustomer(ref bikeShop);
            Helper.PrintBrand(ref bikeShop);
            Helper.ReadAndWriteBrand(ref bikeShop);
            Helper.ReadAndWriteTireSize(ref bikeShop);
            Helper.PrintChoiceOfMetal(ref bikeShop);
            Helper.ReadAndWriteChoiceOfMetall(ref bikeShop);
            Helper.ReadAndWriteDonationAmount(ref bikeShop);
            Console.WriteLine("\nInvoice and Packing Slip");
            Helper.PrintCheck(ref bikeShop);

            Console.ReadLine();
        }
    }
}
