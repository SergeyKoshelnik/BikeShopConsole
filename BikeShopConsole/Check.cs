namespace BikeShopConsole
{
    class Check
    {
        public string Customer { get; set; }
        public string Brand { get; set; }
        public decimal BasePrice { get; set; }
        public decimal TyreSizePremium { get; set; }
        public decimal MetallSelectionPremium { get; set; }
        public decimal SubTotal { get; set; }
        public decimal GST { get; set; }
        public decimal DonationToGreenEarth { get; set; }
        public decimal Total { get; set; }
    }
}
