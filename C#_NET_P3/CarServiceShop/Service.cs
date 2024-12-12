/*
 * Cam Davies
 * 28/10/2024
 * Services Class to create new instances of Services
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceShop
{
    internal class Service
    {
        private static int DefaultIdentificationNumber = 1;
        public static int Count = 0;
        private int IdentificationNumber;
        private String firstName;
        private String lastName;
        private long phoneNumber;
        private String Make;
        private String Model;
        private String Colour;
        private int Year;
        private bool EngOilChange;
        private bool TransOilChange;
        private bool AirFilterChange;
        private Decimal Price;

        // Default constructor
        private Service() {
            Count++;
            this.IdentificationNumber = DefaultIdentificationNumber++;
        }

        // Constructor with parameters. Calls default to track Identification Number
        public Service( string firstName, string lastName, long phoneNumber, string make, string model, string colour, int year, bool engOilChange, bool transOilChange, bool airFilterChange, Decimal price):this()
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.Make = make;
            this.Model = model;
            this.Colour = colour;
            this.Year = year;
            this.EngOilChange = engOilChange;
            this.TransOilChange = transOilChange;
            this.AirFilterChange = airFilterChange;
            this.Price = price;
        }

        // Gets the count
        public int count
        {
            get { return Count; }
        }

        // Gets the Identification number as a string
        public String identificationNumber
        {
            get { return IdentificationNumber.ToString(); }
        }

        // Gets and Sets the First Name
        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        // Gets and Sets the Last Name
        public String LastName
        { 
            get { return lastName; } 
            set { lastName = value; }
        }

        // Gets and sets the Phone Number
        public String PhoneNumber
        {
            get { return phoneNumber.ToString(); }
            set { phoneNumber = Convert.ToInt64(value); }
        }

        // Gets and Sets the Make
        public String make
        { 
            get { return Make; } 
            set { Make = value; }
        }

        // Gets and Sets the Model
        public String model
        {
            get { return Model; }
            set { Model = value; }
        }

        // Gets and Sets the colour
        public String colour
        {
            get { return Colour; }
            set { Colour = value; }
        }

        // Gets and Sets the year
        public String year
        {
            get { return Year.ToString(); }
            set { Year = Convert.ToInt32(value); }
        }

        // Gets and Sets the engine oil change service status
        public String engOilChange
        {
            get { return EngOilChange.ToString(); }
            set { EngOilChange = Convert.ToBoolean(value); }
        }

        // Gets and Sets the transmission oil change status
        public String transOilChange
        {
            get { return TransOilChange.ToString(); }
            set {  TransOilChange = Convert.ToBoolean(value); }
        }

        // Gets and Sets the air filter change status
        public String airFilterChange
        {
            get { return AirFilterChange.ToString(); }
            set { AirFilterChange = Convert.ToBoolean(value); }
        }

        // Gets and Sets the price
        public String price
        {
            get { return Price.ToString(); }
            set {  Price = Convert.ToDecimal(value); }
        }


    }

}
