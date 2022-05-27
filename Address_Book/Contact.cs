using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Address_Book
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public long PhoneNumber { get; set; }
       
        private string _Email;
        public string Email
        {
            set
            {
                this._Email = value;
            }
            get
            { 
                return this._Email;
            }
        }

        internal static void Remove(Contact delete)
        {
            throw new NotImplementedException();
        }
    }

}
