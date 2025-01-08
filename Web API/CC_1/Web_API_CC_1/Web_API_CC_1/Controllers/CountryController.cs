using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Web_API_CC_1.Models;
namespace Web_API_CC_1.Controllers
{
    public class CountryController : ApiController
    {

        public List<Country> c = new List<Country>();
        public CountryController()
        {
            c.Add(new Country { ID = 1, CountryName = "India", Capital = "Delhi" });
            c.Add(new Country { ID = 2, CountryName = "SriLanka", Capital = "Colombo" });
            c.Add(new Country { ID = 3, CountryName = "Japan", Capital = "Tokyo" });
        }
        [HttpGet]
        public List<Country> GetallCountries()
        {
            return c;
        }
        [HttpPost]
        public List<Country> Create([FromBody] Country country)
        {
            c.Add(country);
            return c;
        }
        [HttpPut]
        public List<Country> Update(int id, [FromBody] Country country)
        {
            var CountryList = c.Find(c => c.ID == id);
            if (CountryList == null)
            {
            }
            CountryList.CountryName = country.CountryName;
            CountryList.Capital = country.Capital;
            return c;
        }
        [HttpDelete]
        public List<Country> Delete(int id)
        {
            var country_list = c.Find(c => c.ID == id);
            if (country_list == null)
            {
            }
            c.Remove(country_list);
            return c;
        }
    }
}

