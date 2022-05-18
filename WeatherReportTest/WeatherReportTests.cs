using NUnit.Framework;
using Encapsulation.Models;

using System.Collections.Generic;



namespace Encapsulation.Tests
{
    public class WeatherReporterTests
    {
        private WeatherReporter WeatherReporter1;
        private WeatherReporter WeatherReporter2;
        private WeatherReporter WeatherReporter3;



        [SetUp]
        public void Setup()
        {
            WeatherReporter1 = new WeatherReporter("Cape Town", 8);
            WeatherReporter2 = new WeatherReporter("California", 40);
            WeatherReporter3 = new WeatherReporter("London", 20);


        }

        [Test]
        public void CheckTemperatureTest()
        {
            Assert.AreEqual(WeatherReporter1.CheckTemperature(), "It's too cold 🥶!");
            Assert.AreEqual(WeatherReporter2.CheckTemperature(), "It's too hot 🥵!");
            Assert.AreEqual(WeatherReporter3.CheckTemperature(), "Ahhh...it's just right 😊!");
        }
        [Test]
        public void CheckLocationTest() {
            Assert.AreEqual(WeatherReporter1.CheckLocation(), "🌤");
            Assert.AreEqual(WeatherReporter2.CheckLocation(), "🌅");
            Assert.AreEqual(WeatherReporter3.CheckLocation(), "🌦");
        }
        
        
       

    }
}