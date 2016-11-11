using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBook
{
    public class ContactAdress
    {
        public int ContactAdressID { get; set; }
        public int ContactID { get; set; }
        public virtual Contact Contact { get; set; }
        public int AdressTypeID { get; set; }
        public virtual AdressType AdressType { get; set; }
        public string Adress { get; set; }
        
    }
}
