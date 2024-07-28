using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerClientApplication
{
    public partial class Contact
    {
        private string firstName;
        private string lastName;
        private Address address;
        private Comms comms;
        private Image image;

        public Contact()
        {
            Address address = new Address();
            Comms comms = new Comms();
            Image image = new Image();
        }

        public Contact(Contact other)
        {
            this.firstName = other.firstName;
            this.lastName = other.lastName; 
            this.address = other.address;
            this.comms = other.comms;
            this.image = other.image;
        }

        public Contact(string firstName, string lastName, Address address, Comms comms, Image image)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.comms = comms;
            this.image = image;
        }

        public string FirstName
        {
            get { return  firstName; } set
            {
                if (value != null)
                    firstName = value;
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                if (value != null)
                    lastName = value;
            }
        }

        public Address Address
        {
            get { return address; }
            set { if(value != null)
                    address = value; }
        }

        public Comms Comms
        {
            get { return comms; }
            set { if(value != null)
                    comms = value;}
        }

        public Image Image
        {
            get { return image; }
            set
            {
                if (value != null)
                    image = value;
            }
        }

        public string FullName()
        {
            return firstName + " " + lastName;
        }




    }
}
