using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.Api.Infrastucture
{
    public interface IContactService
    {
        public ContactDTO GetContactId(int Id);
    }
}
