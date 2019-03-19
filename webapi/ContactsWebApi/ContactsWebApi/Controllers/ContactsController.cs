using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ContactsWebApi.Models;
using ContactsWebApi.Services;

namespace ContactsWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public ActionResult<List<Contact>> Get()
        {
            return new JsonResult(_contactService.Read());
        }

        [HttpGet("{id}")]
        public ActionResult<Contact> Get(int id)
        {
            return new JsonResult(_contactService.Read(id));
        }

        [HttpPost]
        public ActionResult<Contact> Create(Contact contact)
        {
            return _contactService.CreateContact(contact);
        }

        [HttpPut]
        public ActionResult<Contact> Update(int id, Contact contact)
        {
            return _contactService.Update(id, contact);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _contactService.Delete(id);
            return new NoContentResult();
        }
    }
}
}