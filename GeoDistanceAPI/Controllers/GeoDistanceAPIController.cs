using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using GeoDistanceAPI.Models;
using Newtonsoft.Json.Linq;

namespace GeoDistanceAPI.Controllers
{
    [Route("api/[controller]")]
    public class GeoDistanceAPIController : Controller
    {
        // ideally these should be made Resource strings as they have to be displayed on UI
        private const string wellcomeNote = "Wellcome to GeoDistanceAPI Kindly provide following information:" +
                               "First City: Latitude & Longitude, Second City: Latitude & Longitude";
        private const string LocationA = "locationA";
        private const string LocationB = "locationB";
        private const string JSonFormatError = "Further, Consult to readme.md file for correct JSON formatting";

        // GET: api/GeoDistanceAPI
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { wellcomeNote };
        }

        // POST api/GeoDistanceAPI/
        [HttpPost]
        public string PostCalculateDistance([FromBody]JObject coords)
        {
            string distanceInKm = string.Empty;
            try
            {
                var cityA = new City(coords[LocationA].ToObject<Coordinates>());
                var cityB = new City(coords[LocationB].ToObject<Coordinates>());
                distanceInKm = cityA.FindDistance(cityB.Coordinates).ToString();
            }
            catch (Exception ex)
            {
                return $"{ex.Source}:\t{ex.Message}\n{JSonFormatError}";
            }
            return distanceInKm;
        }
    }
}
