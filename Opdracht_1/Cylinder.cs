using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    /// <summary>
    /// The class Cylinder represents a cylindrical flower box
    /// </summary>
    public class Cylinder
    {
        /// <summary>
        /// The diameter of the flower box
        /// </summary>
        private int diameter;
        public int Diameter
        {
            get { return diameter; }
            set { diameter = value; }
        }

        /// <summary>
        /// The height of the flower box
        /// </summary>
        private int height;
        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        /// <summary>
        /// the surface of the flower box
        /// </summary>
        public double Surface
        {
            //Surface = PI * diameter
            get { return Math.Round((Math.PI * diameter), 2); }
        }

        /// <summary>
        /// The volume of the flower box
        /// </summary>
        public double Volume
        {
            //volume = 1/4 * PI * diameter * diameter * height
            get { return Math.Round((0.25 * Math.PI * diameter * diameter * height), 2); }
        }

        /// <summary>
        /// The design of the flower box
        /// </summary>
        public string Print
        {
            get
            {

                return "Cilindervormige bloemenbak\r\n" +
                    "Diameter: " + this.diameter + " cm\r\n" +
                    "Hoogte: " + this.height + " cm\r\n" +
                    "Oppervlakte: " + this.Surface + " cm2\r\n" +
                    "Volume: " + this.Volume + " cm3\r\n" +
                    string.Format("Price: {0:C}", FlowerBoxPrice.Price(this.Volume)); 
            }
        }

        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="diameter">The diameter of the flower box, diameter '<' 101</param>
        /// <param name="height">The height of the flower box, height '<' 101</param>
        public Cylinder(int diameter, int height)
        {
            if (diameter > 0 && diameter < 101 && height > 0 && height < 101)
            {
                this.diameter = diameter;
                this.height = height;
            }
            else
                throw new ArgumentException("The diameter and height must be smaler then 100");
        }
    }
}
