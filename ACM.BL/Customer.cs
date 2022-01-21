using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
     
    public class Customer
    {
        public string CustomerID { get; private set; }

       
        public string emailAddress { get; private set; }
        private string _lastname;
        private string _firstName;

        public string Fullname {
            get
            {
                return lastname + "," + firstname;
            }
                 }

        public string firstname
        {
            get { return _firstName; }


            set { _lastname = value; }

        }
        public string lastname
        {
            get { return _lastname; }


            set { _lastname = value; }

        }
    }
}
