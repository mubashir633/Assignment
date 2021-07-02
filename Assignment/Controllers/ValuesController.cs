using Assignment.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace Assignment.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values/5
        public string Get(int HotelID, string ArrivalDate)
        {
            string allText = System.IO.File.ReadAllText(HttpContext.Current.Server.MapPath("~/hotelsrates.json"));

            List<ResultJson> jsonObject = JsonConvert.DeserializeObject<List<ResultJson>>(allText);
            var filterHotelResult = jsonObject.Where(x => x.Hotel.HotelID == HotelID).FirstOrDefault();
            var filterHotelRateResult = filterHotelResult.HotelRates.Where(x => x.TargetDay.Date == Convert.ToDateTime(ArrivalDate)).FirstOrDefault();
            ResultJson response = new ResultJson
            {
                Hotel = filterHotelResult.Hotel,
                HotelRates = new List<HotelRate>()
            };
            response.HotelRates.Add(filterHotelRateResult);
            return JsonConvert.SerializeObject(response);
        }

    }
}
