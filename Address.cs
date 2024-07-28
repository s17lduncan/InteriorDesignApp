using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerClientApplication
{
    public class Address
    {
        private string street;
        private string city;
        private State state;
        private string zipCode;
        public Address() { }

        public Address(string street, string city, string zipCode, State state)
        {
            this.street = street;
            this.city = city;
            this.zipCode = zipCode;
            this.state = state;
        }

        public Address (Address other)
        {
            this.street = other.street;
            this.city = other.city; 
            this.zipCode = other.zipCode;
            this.state = other.state;
        }

        public string Street
        {
            get { return this.street; }
            set {if (value != null)
                    street = value;
            }
        }

        public string City
        { get { return this.city; }
          set { if (value != null)
                    city = value;  }
        }


        public string ZipCode
        {
            get { return this.zipCode; }
            set
            {
                if (value != null)
                    zipCode = value;
            }
        }

        public State State
        {
            get { return this.state; }
            set { state = value; }
        }

        private string stateToString()
        {
            string stateString = state.ToString();

            if (stateString.Contains("_"))
            {
                stateString.Replace("_", " ");
            }

            return stateString;
        }

        public override string ToString()
        {
            string stateStr = stateToString();

            return String.Format("{0,5} {1,5} {2,5} {3,5}",
                street, city, zipCode, stateStr);
        }


    }
}
