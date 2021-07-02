using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class HotelRate
    {
        public int Adults { get; set; }
        public int Los { get; set; }
        public string Name { get; set; }
        public float Reviewscore { get; set; }
        public double RateID { get; set; }
        public string RateName { get; set; }
        public string RateDescription { get; set; }
        public DateTimeOffset TargetDay { get; set; }
        public List<Tag> RateTags { get; set; }
        public Price Price { get; set; }

    }

    public class Price
    {
        public string Currency { get; set; }
        public float NumericFloat { get; set; }
        public int NumericIngteger { get; set; }
    }
    public class Tag
    {
        public string Name { get; set; }
        public string Shape { get; set; }
    }
}