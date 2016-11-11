using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    public class ContactTelephoneNumber
    {
        public int ContactTelephoneNumberID { get; set; }        
        public int ContactID { get; set; }
        public virtual Contact Contact { get; set; }
        public int TelephoneTypeID { get; set; }
        public virtual TelephoneType TelephoneType { get; set; }
        public string TelefonNumber { get; set; }
    }
}
