using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using W05Lab.Models;

namespace W05Lab.Data
{
    public class SampleData
    {
        public static List<City> GetCities() {
            List<City> cities = new List<City>() {
                new City() {
                    CityId=1,
                    CityName="Vancouver",
                    Population=123456,
                    ProvinceCode="BC",
                },
                new City() {
                    CityId=2,
                    CityName="Richmond",
                    Population=234567,
                    ProvinceCode="BC",
                },
                new City() {
                    CityId=3,
                    CityName="Burnaby",
                    Population=345678,
                    ProvinceCode="BC",
                },
                new City() {
                    CityId=4,
                    CityName="Calgary",
                    Population=456789,
                    ProvinceCode="AB",
                },
                new City() {
                    CityId=5,
                    CityName="Edmonton",
                    Population=567890,
                    ProvinceCode="AB",
                },
                new City() {
                    CityId=6,
                    CityName="Grande Prairie",
                    Population=678901,
                    ProvinceCode="AB",
                },
                new City() {
                    CityId=7,
                    CityName="Toronto",
                    Population=789012,
                    ProvinceCode="ON",
                },
                new City() {
                    CityId=8,
                    CityName="Ottawa",
                    Population=890123,
                    ProvinceCode="ON",
                },
                new City() {
                    CityId=9,
                    CityName="Hamilton",
                    Population=901234,
                    ProvinceCode="ON",
                },
            };

            return cities;
        }

        public static List<Province> GetProvinces() {
            List<Province> provinces = new List<Province>() {
                new Province {
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia",
                },
                new Province {
                    ProvinceCode = "AB",
                    ProvinceName = "Alberta",
                },
                new Province {
                    ProvinceCode = "ON",
                    ProvinceName = "Ontario",
                },
            };

            return provinces;
        }
    }
}