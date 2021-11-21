using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    /// <summary>
    /// Static class for calculating the flower box price
    /// </summary>
    public static class FlowerBoxPrice
    {
        /// <summary>
        /// The static method calculates the price of the flower box based on its volume
        /// </summary>
        /// <param name="volume">The volume of the flower box in cm3</param>
        /// <returns></returns>
        public static decimal Price(double volume)
        {
            volume /= 1000000;
            if (volume > 0 && volume <= 0.2)
                return 40;
            else if (volume > 0.2 && volume <= 0.4)
                return 80;
            else if (volume > 0.4 && volume <= 0.6)
                return 140;
            else if (volume > 0.6 && volume <= 0.8)
                return 210;
            else if (volume > 0.8 && volume <= 1)
                return 250;
            else
                throw new ArgumentException("The volume is beyound his bouderies");
        }
    }
}
