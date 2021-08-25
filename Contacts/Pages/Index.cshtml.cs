using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contact.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Contacts.Pages
{
    public class IndexModel : PageModel
    {
       

       
        public void OnGet()
        {
           
        }

        public void OnPost([FromBody] AddContactRequest addContactRequest)
        {
            
            
        }

    }
}
