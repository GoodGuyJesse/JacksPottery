using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    public class Beam
    {
        private int length;
        /// <summary>
        /// The length of the beam
        /// </summary>
        public int Length
        {
            get { return length; }
            set { length = value; }
        }

        private int width;
        /// <summary>
        /// The width of the beam
        /// </summary>
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        private int height;
        /// <summary>
        /// The height of the beam
        /// </summary>
        public int Heigth
        {
            get { return height; }
            set { height = value; }
        }

        /// <summary>
        /// True is the beam is a cube, otherwise false
        /// </summary>
        private bool IsCube
        {
            get 
            {
                if (length == width && width == height)
                    return true;
                else 
                    return false;
            }
        }

        /// <summary>
        /// The volume of the cube
        /// </summary>
        public int Volume
        {
            get { return length * width * height; }
        }

        /// <summary>
        /// Complete constructor
        /// </summary>
        /// <param name="length">The length of the cube</param>
        /// <param name="width">The width of the cube</param>
        /// <param name="height">The heigth of the cube</param>
        public Beam(int length, int width, int height)
        {
            if (length > 0 && length < 101 && width > 0 && width < 101 
                && height > 0 && height < 101)
            {
                this.length = length;
                this.width = width;
                this.height = height;
            }
            else
                throw new ArgumentException("The length, width and height must be smaler then 100");
        }

        /// <summary>
        /// The method prints the dimensions, volume and shape of the beam
        /// </summary>
        /// <returns>A string with information about the beam</returns>
        public string Print()
        {
            string mesurements = "Lengte = " + length + " cm\r\n" +
                    "breedte = " + width + " cm\r\n" +
                    "Hoogte = " + height + " cm \r\n" +
                    "Inhoud van de bloemenbak: " + Volume + " cm3";

            if (IsCube)
            {
                return "Bestelling: Kubes vormige bloemenbak \r\n" + mesurements +
                    string.Format("\r\nPrice: {0:C}", FlowerBoxPrice.Price(this.Volume));
            }
            else
                return "Bestelling: Balk vormige bloemenbak \r\n" + mesurements +
                    string.Format("\r\nPrice: {0:C}", FlowerBoxPrice.Price(this.Volume));
        }
    }
}
