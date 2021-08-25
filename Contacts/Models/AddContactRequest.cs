using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contact.Models
{
    public class AddContactRequest
    {
        public string Name { get;  set; }
        public uint Age { get;  set; }
        public string Occupation { get;  set; }
        public string Email { get;  set; }
        public string Phone { get;  set; }
      
    }
}
