using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2
{
    /// <summary>
    /// Class Customer, here with automatic properties. See the difference with the Beam class properties
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// The first name of the customer
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The middle name of the customer
        /// </summary>
        public string MiddleName { get; set; }

        /// <summary>
        /// The last name of the customer 
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The address of the customer
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// The city of the customer
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// The postalcode of the customer
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// Complete constructor
        /// </summary>
        /// <param name="firstname">The first name of the customer</param>
        /// <param name="middlename">The middle name of the customer</param>
        /// <param name="lastname">The last name of the customer</param>
        /// <param name="address">The address of the customer</param>
        /// <param name="city">The city of the customer</param>
        /// <param name="postalCode">The postalcode of the customer</param>
        public Customer(string firstname, string middlename, string lastname, 
            string address, string city, string postalCode)
        {
            FirstName = firstname;
            MiddleName = middlename;
            LastName = lastname;
            Address = address;
            City = city;
            PostalCode = postalCode;
        }

        public Customer()
        { }

        /// <summary>
        /// The method prints the name and address of the customer
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            return "Klant :\r\n" +
                FirstName + " " + MiddleName + " " + LastName + "\r\n" +
                Address + "\r\n" +
                PostalCode + "\r\n" +
                City + "\r\n\r\n";
        }
    }
}
