using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string ContactName { get; set; }
        public virtual List<ContactAdress> ContactAdresses { get; set; }
        public virtual List<ContactTelephoneNumber> ContactTelephoneNumbers { get; set; }

    }
}
