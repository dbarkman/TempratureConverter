using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TempratureConverter;

namespace TempConverterTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TempConverter tempConverter = new TempConverter();
            float fahrenheit = 0;
            float expectedResult = -18;
            float actualResult = tempConverter.convertToCelsius(fahrenheit);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            TempConverter tempConverter = new TempConverter();
            float fahrenheit = 32;
            float expectedResult = 0;
            float actualResult = tempConverter.convertToCelsius(fahrenheit);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            TempConverter tempConverter = new TempConverter();
            float fahrenheit = 212;
            float expectedResult = 100;
            float actualResult = tempConverter.convertToCelsius(fahrenheit);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            TempConverter tempConverter = new TempConverter();
            float celsius = -18;
            float expectedResult = 0;
            float actualResult = tempConverter.convertToFahrenheit(celsius);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod5()
        {
            TempConverter tempConverter = new TempConverter();
            float celsius = 0;
            float expectedResult = 32;
            float actualResult = tempConverter.convertToFahrenheit(celsius);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod6()
        {
            TempConverter tempConverter = new TempConverter();
            float celsius = 100;
            float expectedResult = 212;
            float actualResult = tempConverter.convertToFahrenheit(celsius);
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
