using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AzureApiTest2.Models;

namespace AzureApiTest2.Controllers
{
    public class ContactsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            return new Contact[]{
                
                new Contact { Id = 1, EmailAddress = "barney@contoso.com", Name = "Barney Poland"},
                new Contact { Id = 2, EmailAddress = "lacy@contoso.com", Name = "Lacy Barrera"},
                new Contact { Id = 3, EmailAddress = "lora@microsoft.com", Name = "Lora Riggs"},
                new Contact { Id = 4, EmailAddress = "deploy@microsoft.com", Name = "Next Deploy Tester"}
            };
        }
    }
}
