using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerClientApplication
{
    public class Comms
    {
        private string email;
        private string phone;

        public Comms() { }

        public Comms(string email, string phone)
        {
            this.email = email;
            this.phone = phone;
        }

        public Comms(Comms other)
        {
            this.email = other.email;
            this.phone = other.phone;
        }

        public string Email
        {
            get { return this.email; }
            set { if (value != null)
                    email = value;
            }
        }

        public string Phone
        {
            get { return this.phone; }
            set { if (value != null)
                    phone = value;}
        }


    }
}
