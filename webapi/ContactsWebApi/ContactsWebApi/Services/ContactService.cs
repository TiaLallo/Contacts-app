using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsWebApi.Models;
using ContactsWebApi.Repositories;

namespace ContactsWebApi.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public Contact CreateContact(Contact contact)
        {
            return _contactRepository.CreateContact(contact);
        }

        public void Delete(int id)
        {
            _contactRepository.Delete(id);
        }

        public List<Contact> Read()
        {
            return _contactRepository.Read();
        }

        public Contact Read(int id)
        {
            return _contactRepository.Read(id);
        }

        public Contact Update(int id, Contact contact)
        {
            return _contactRepository.Update(id, contact);
        }
    }
}