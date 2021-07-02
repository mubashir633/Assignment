using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class Hotel
    {
        public int Classification { get; set; }
        public int HotelID { get; set; }
        public string Name { get; set; }
        public float Reviewscore { get; set; }
    }
}