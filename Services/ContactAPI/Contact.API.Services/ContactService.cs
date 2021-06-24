using Contact.Api.Infrastucture;
using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactId(int Id)
        {
            return new ContactDTO()
            {
                Id = Id,
                FirstName = "Araz",
                LastName = "Qasimov"
            };
        }
    }
}
