using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    class ContactAdress
    {
        public int ContactID { get; set; }
        public virtual Contact Contact { get; set; }
        public int AdressTypeID { get; set; }
        public virtual AdressType AdressType { get; set; }
        public string Adress { get; set; }
    }
}
