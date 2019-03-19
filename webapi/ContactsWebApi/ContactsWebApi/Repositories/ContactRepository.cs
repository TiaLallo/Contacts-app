using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactsWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactsWebApi.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private ContactdbContext _context;

        public ContactRepository(ContactdbContext context)
        {
            _context = context;
        }

        public Contact CreateContact(Contact contact)
        {
            _context.Add(contact);
            _context.SaveChanges();
            return contact;
        }

        public void Delete(int id)
        {
            var contact = Read(id);
            _context.Remove(contact);
            _context.SaveChanges();
        }

        public List<Contact> Read()
        {
            return _context.Contact.AsNoTracking().ToList();
        }

        public Contact Read(int id)
        {
            return _context.Contact.AsNoTracking().FirstOrDefault(c => c.Id == id);
        }

        public Contact Update(int id, Contact contact)
        {
            _context.Update(contact);
            _context.SaveChanges();
            return contact;
        }
    }
}