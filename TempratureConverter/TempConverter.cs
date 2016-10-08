using System;

namespace TempratureConverter
{
    public class TempConverter
    {
        public float convertToCelsius(float fahrenheit)
        {
            return (float)Math.Round((fahrenheit - 32) / 9 * 5);
        }

        public float convertToFahrenheit(float celsius)
        {
            return (float)Math.Round(celsius * 9 / 5 + 32);
        }
    }
}