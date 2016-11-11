using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    class Contact
    {
        public int ContactID { get; set; }
        public int ContactName { get; set; }
        public virtual List<ContactAdress> ContactAdresses { get; set; }
        public virtual List<ContactTelephoneNumber> ContactTelephoneNumbers { get; set; }

    }
}
