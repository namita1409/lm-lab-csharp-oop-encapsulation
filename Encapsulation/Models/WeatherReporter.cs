using System;
namespace Encapsulation.Models
{
    public class WeatherReporter
    {
        //changing variable access modifiers from public to private
        private string location;
        private double temperature;
        private const int FAHRENHEIT_TEMPERATURE = 32;

        public WeatherReporter(string location, double temperature)
        {
            this.location = location;
            this.temperature = temperature;
        }

        //changing method name from Print to GetWeatherReport
        public string GetWeatherReport()
        {
            double newTemp = (9.0 / 5.0) * temperature + FAHRENHEIT_TEMPERATURE;
            return $"I am in {location} and it is {CheckLocation()}. {CheckTemperature()}. The temperature in Fahrenheit is {newTemp}.";
        }

        /*changing method name from check1() to CheckLocation*/
       
        public string CheckLocation()
        {           

            Console.WriteLine(location);
            if (location == "London")
            {

                return "🌦";

            }
            else if (location == "California")
            {

                return "🌅";

            }
            else if (location == "Cape Town")
            {

                return "🌤";

            }
            return "🔆";
        }

        /* changing the method name from chek2() to CheckTemperature()*/          

        public string CheckTemperature()
        {           

            Console.WriteLine(temperature);
            if (temperature > 30)
            {

                return "It's too hot 🥵!";

            }
            else if (temperature < 10)
            {

                return "It's too cold 🥶!";

            }
            return "Ahhh...it's just right 😊!";
        }

    }
}

