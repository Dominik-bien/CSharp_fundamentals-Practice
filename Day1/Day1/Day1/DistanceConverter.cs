using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public static class DistanceConverter
    {
        public static double KilometersToMiles(double kilometers)
        {
            return kilometers * 0.621371;
        }
        public static double MilesToKilometers(double miles)
        {
            return miles / 0.621371;
        }
    }
}
