using Microsoft.VisualStudio.TestTools.UnitTesting;
using dsihra1_Test3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsihra1_Test3.Tests
{
    [TestClass()]
    public class TempConvertTests
    {
        [TestMethod()]
        public void TempConvertTest()
        {
            int need = 0;
            int expected = 32;

            TempConvert tem = new TempConvert(need, SysOfUnits.Celsius);

            decimal actual = tem.InFahrenheit;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Temp()
        {
            int need = -220;
            int expected = -140;

            TempConvert tem = new TempConvert(need, SysOfUnits.Fahrenheit);

            decimal actual = tem.InCelsius;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TemBoilingPointofWater()
        {
            int need = 212;
            int expected = 100;

            TempConvert tem = new TempConvert(need, SysOfUnits.Fahrenheit);

            decimal actual = tem.InCelsius;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TempFahtoKelvin()
        {
            int need = 0;
            decimal expected = 255.37m;
 
            TempConvert tem = new TempConvert(need, SysOfUnits.Fahrenheit);

            decimal actual = tem.InKelvin;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TempCeltoKelvin()
        {
            int need = 0;
            decimal expected = 273.15m;

            TempConvert tem = new TempConvert(need, SysOfUnits.Celsius);

            decimal actual = tem.InKelvin;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void TempKelvintoFah()
        {
            int need = 0;
            decimal expected = -459.67m;

            TempConvert tem = new TempConvert(need, SysOfUnits.Kelvin);

            decimal actual = tem.InFahrenheit;

            Assert.AreEqual(expected, actual);
        }



        [TestMethod()]
        public void TempNegCeltoFah()
        {
            decimal need = -40;
            decimal expected = -40;

            TempConvert tem = new TempConvert(need, SysOfUnits.Celsius);

            decimal actual = tem.InFahrenheit;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TempNegNegFahtoNegCel()
        {
            decimal need = -40;
            decimal expected = -40;

            TempConvert tem = new TempConvert(need, SysOfUnits.Fahrenheit);

            decimal actual = tem.InCelsius;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TempNegFahToZeroKelvin()
        {
            decimal need = -459.67m;
            decimal expected = 0;

            TempConvert tem = new TempConvert(need, SysOfUnits.Fahrenheit);

            decimal actual = tem.InKelvin;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TempKevlinCelConvert()
        {
            decimal need = 54;
            decimal expected = -219.15m;

            TempConvert tem = new TempConvert(need, SysOfUnits.Kelvin);

            decimal actual = tem.InCelsius;
           

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TempNegFah()
        {
            decimal need = -25m;
            decimal expected = -13m;

            TempConvert tem = new TempConvert(need, SysOfUnits.Celsius);

            decimal actual = tem.InFahrenheit;


            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TempNegFahtoKelvin()
        {
            decimal need = -25m;
            decimal expected = 241.48m;

            TempConvert tem = new TempConvert(need, SysOfUnits.Fahrenheit);

            decimal actual = tem.InKelvin;


            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TempCelNegfromKel()
        {
            decimal need = 233.15m;
            decimal expected = -40m;

            TempConvert tem = new TempConvert(need, SysOfUnits.Kelvin);

            decimal actual = tem.InCelsius;


            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void TempfreezingpointofalcoholinFah()
        {
            decimal need = 114.1m;
            decimal expected = 237.38m;

            TempConvert tem = new TempConvert(need, SysOfUnits.Celsius);

            decimal actual = tem.InFahrenheit;


            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void TempZeroFahfromCel()
        {
            decimal need = -17.7778m;
            decimal expected = 0;

            TempConvert tem = new TempConvert(need, SysOfUnits.Celsius);

            decimal actual = tem.InFahrenheit;


            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]

        public void Tempnegativeforty()
        {
            decimal need = -40m;
            decimal expected = -40;

            TempConvert tem = new TempConvert(need, SysOfUnits.Fahrenheit);

            decimal actual = tem.InCelsius;


            Assert.AreEqual(expected, actual);
        }


    }
}