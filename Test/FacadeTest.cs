using System;
using NUnit.Framework;
using WeatherServices;
using Facade;

namespace Tests
{
    public class FacadeTest
    {
        [Test]
        public void WithoutFacadeTest()
        {
            const string zipCode = "83714";

            GeoLookupService geoLookupService = new GeoLookupService();
            
            var city = geoLookupService.GetCityForZipCode(zipCode);
            var state = geoLookupService.GetStateForZipCode(zipCode);
            var coords = geoLookupService.GetCoordinatesForZipCode(zipCode);

            WeatherService weatherService = new WeatherService();
            var farenheit = weatherService.GetTempFarenheit(coords.Latitude, coords.Longitude);

            EnglishMetricConverter englishMetricConverter = new EnglishMetricConverter();
            var celcius = englishMetricConverter.FarenheitToCelcious(farenheit);

            Console.WriteLine("The current temperature is {0}F/{1}C. in {2}, {3}", 
                                farenheit.ToString("F1"), 
                                celcius.ToString("F1"), 
                                city, 
                                state);
        }

        [Test]
        public void WithFacadeTest()
        {
            const string zipCode = "83714";

            var temperatureFacade = new TemperatureLookupFacade();
            LocalTemperature localTemp = temperatureFacade.GetTemperature(zipCode);

            Console.WriteLine("The current temperature is {0}F/{1}C. in {2}, {3}",
                                localTemp.Farenheit.ToString("F1"), 
                                localTemp.Celcius.ToString("F1"), 
                                localTemp.City, 
                                localTemp.State);
        }
    }
}