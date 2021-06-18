using System;

namespace BikeShop.Models
{
    public class Holidays
    {
        public DateTime Date { get; set; }
        public string LocalName { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public bool Fixed { get; set; }
        public bool Global { get; set; }
        public string Countries { get; set; }
        public string LaunchYear { get; set; }
        public string Type { get; set; }

    }
}