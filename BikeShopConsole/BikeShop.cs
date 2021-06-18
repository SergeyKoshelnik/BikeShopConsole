namespace BikeShopConsole
{
    class BikeShop
    {
        public string Customer { get; set; }
        private readonly string[] _brand;
        public string[] Brand { get { return _brand; } set { } }
        public int TireSize { get; set; }
        private readonly string[] _choiceOfMetal;
        public string[] ChoiceOfMetal { get { return _choiceOfMetal; } set { } }
        internal Check check;

        public BikeShop()
        {

            _brand = new string[] { "Trek", "Giant", "Specialized", "Raleigh" };
            _choiceOfMetal = new string[] { "Steel", "Aluminium", "Titanium", "Carbon Fiber" };
            check = new Check();

        }

    }
}
