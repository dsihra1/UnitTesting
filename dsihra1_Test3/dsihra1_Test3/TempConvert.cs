using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsihra1_Test3
{
    public enum SysOfUnits
    {
        Kelvin,
        Celsius,
        Fahrenheit
    }
    public class TempConvert
    {
        decimal t; 

        public TempConvert(decimal temp, SysOfUnits u)
        {
            if (u == SysOfUnits.Celsius)
            {
                t = temp;
            }
            else if (u == SysOfUnits.Kelvin)
            {
                t = temp - 273.15m;
            }
            else
            {
                t = (temp - 32m) * 5m / 9m;
            }
            if (t < -273.15m)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
        public decimal InCelsius
        {
            get
            {
                return Math.Round(t, 2);
            }
        }
        public decimal InKelvin
        {
            get
            {
                return Math.Round(t + 273.15m, 2);
            }
        }
        public decimal InFahrenheit
        {
            get
            {
                return Math.Round((t * 9m / 5m) + 32m, 2);
            }
        }
    }
}
