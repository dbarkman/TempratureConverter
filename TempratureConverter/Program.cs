using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempratureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] temps = new float[] { 0, 32, 212};
            TempConverter tempConverter = new TempConverter();
            foreach (float i in temps)
            {
                float celsius = tempConverter.convertToCelsius(i);
                float fahrenheit = tempConverter.convertToFahrenheit(celsius);
                Console.WriteLine(i + " degrees Fahrenheit is " + celsius + " degrees Celsius");
                Console.WriteLine(celsius + " degrees Celsius is " + fahrenheit + " degrees Fahrenheit");
            }
        }
    }
}
