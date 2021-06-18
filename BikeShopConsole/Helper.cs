using System;

namespace BikeShopConsole
{

    static class Helper
    {
        private static string selectedBrand;
        private static int selectedTireSize;
        private static int selectedChoiceOfMetall;
        private static string symbolDonationAnswer;
        private static decimal amountSum;

        static public void ReadAndWriteCustomer(ref BikeShop bs)
        {
            Console.Write("Enter your name: ");
            bs.Customer = Console.ReadLine();
            bs.check.Customer = bs.Customer;
        }
        static public void ReadAndWriteBrand(ref BikeShop bs)
        {
            do
            {
                Console.Write("Make a selection [a,b,c,d] >>  ");
                selectedBrand = Console.ReadLine().ToUpper();

            } while (selectedBrand != "A" && selectedBrand != "B" && selectedBrand != "C" && selectedBrand != "D");

            switch (selectedBrand)
            {
                case "A":
                    bs.check.Brand = bs.Brand[0];
                    bs.check.BasePrice = 250.00M;
                    break;
                case "B":
                    bs.check.Brand = bs.Brand[1];
                    bs.check.BasePrice = 350.00M;
                    break;
                case "C":
                    bs.check.Brand = bs.Brand[2];
                    bs.check.BasePrice = 500.00M;
                    break;
                case "D":
                    bs.check.Brand = bs.Brand[3];
                    bs.check.BasePrice = 600.00M;
                    break;
                default: break;
            }
        }
        static public void ReadAndWriteTireSize(ref BikeShop bs)
        {
            do
            {
                Console.Write("Choose a tire size [20-26] @ 17.50 per inch >> ");

                try
                {
                    selectedTireSize = Int32.Parse(Console.ReadLine());
                    if (selectedTireSize < 20 || selectedTireSize > 26)
                    {
                        throw new Exception("Error value!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (selectedTireSize < 20 || selectedTireSize > 26);

            bs.TireSize = selectedTireSize;
            bs.check.TyreSizePremium = Decimal.Round((decimal)(selectedTireSize * 17.50), 2);
        }
        static public void ReadAndWriteChoiceOfMetall(ref BikeShop bs)
        {
            do
            {
                Console.Write("Choice [1-4] >> ");

                try
                {
                    selectedChoiceOfMetall = Int32.Parse(Console.ReadLine());
                    if (selectedChoiceOfMetall < 1 || selectedChoiceOfMetall > 4)
                    {
                        throw new Exception("Error value!");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } while (selectedChoiceOfMetall < 1 || selectedChoiceOfMetall > 4);

            switch (selectedChoiceOfMetall)
            {
                case 1:
                    bs.check.MetallSelectionPremium = 0.00M;
                    break;
                case 2:
                    bs.check.MetallSelectionPremium = 175.00M;
                    break;
                case 3:
                    bs.check.MetallSelectionPremium = 425.00M;
                    break;
                case 4:
                    bs.check.MetallSelectionPremium = 615.00M;
                    break;
                default: break;
            }
        }
        static public void ReadAndWriteDonationAmount(ref BikeShop bs)
        {
            do
            {
                Console.Write("Would you like to make a donation to the Green Earth Fund [y/n] >> ");
                symbolDonationAnswer = Console.ReadLine().ToUpper();

            } while (symbolDonationAnswer != "Y" && symbolDonationAnswer != "N");

            switch (symbolDonationAnswer)
            {
                case "Y":
                    do
                    {
                        Console.Write("Amount >> ");
                        try
                        {
                            amountSum = decimal.Parse(Console.ReadLine().Replace(".", ","));
                            if (amountSum <= 0)
                            {
                                throw new Exception("Error value! Please, make your donation");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                    } while (amountSum <= 0);

                    bs.check.DonationToGreenEarth = Decimal.Round(amountSum, 2);
                    break;
                case "N":
                    bs.check.DonationToGreenEarth = 0.00M;
                    break;
                default: break;
            }
        }


        static public void PrintBrand(ref BikeShop bs)
        {
            Console.WriteLine("Brand");
            Console.WriteLine(@"    {0}) {1}", "a", bs.Brand[0]);
            Console.WriteLine(@"    {0}) {1}", "b", bs.Brand[1]);
            Console.WriteLine(@"    {0}) {1}", "c", bs.Brand[2]);
            Console.WriteLine(@"    {0}) {1}", "d", bs.Brand[3]);
        }
        static public void PrintChoiceOfMetal(ref BikeShop bs)
        {
            Console.WriteLine("Enter the number of your corresponding choice of metal.");
            Console.WriteLine(@"    {0}. {1} [$0]", "1", bs.ChoiceOfMetal[0]);
            Console.WriteLine(@"    {0}. {1} [$175]", "2", bs.ChoiceOfMetal[1]);
            Console.WriteLine(@"    {0}. {1} [$425]", "3", bs.ChoiceOfMetal[2]);
            Console.WriteLine(@"    {0}. {1} [$615]", "4", bs.ChoiceOfMetal[3]);
        }
        static public void PrintCheck(ref BikeShop bs)
        {
            bs.check.SubTotal = bs.check.BasePrice + bs.check.TyreSizePremium + bs.check.MetallSelectionPremium;
            bs.check.GST = Decimal.Round((bs.check.SubTotal * 5 / 100), 2);
            bs.check.Total = bs.check.SubTotal + bs.check.GST + bs.check.DonationToGreenEarth;


            Console.WriteLine($@"
Customer:                   {bs.check.Customer}
Brand:                      {bs.check.Brand}
Base Price:                         {bs.check.BasePrice}
Tire Size Premium:                  {bs.check.TyreSizePremium}
Metall Selection Premium:           {bs.check.MetallSelectionPremium}
                                    ---------
Sub Total:                          {bs.check.SubTotal}
GST:                                {bs.check.GST}
                                    =========
Donation to Green Earth             {bs.check.DonationToGreenEarth}
Total:                              {bs.check.Total}");


            Console.WriteLine("\nPress any key to continue...");
        }
    }
}
