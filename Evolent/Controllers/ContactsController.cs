using Evolent.Models;
using Evolent.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace Evolent.Controllers
{
    public class ContactsController : ApiController
    {
        IContactRepository _service;

        public ContactsController()
        {
            _service = new ContactRepository();
        }
        // GET: api/Contacts
        public IEnumerable<Contact> GetAll()
        {
            List<Contact> contacts = new List<Contact>();
            contacts = _service.GetAll().ToList();
            return contacts;
        }

        // GET: api/Contacts/5
        [ResponseType(typeof(Contact))]
        public IHttpActionResult Get(int id)
        {
            Contact contact = _service.Get(id);
            return this.Ok(contact);
        }

        // POST: api/Contacts
        
        public HttpResponseMessage Post([FromBody]Contact contact)
        {
            _service.Add(contact);
            var response = Request.CreateResponse(HttpStatusCode.Created, contact);

            var uri = Url.Link("DefaultApi", new { id = contact.Id });
            response.Headers.Location = new Uri(uri);

            return response;
            //TODO: If success return success message
        }

        // PUT: api/Contacts/5
        public int Put([FromBody]Contact contact)
        {
            int updatedContacts = _service.Update(contact);
            return updatedContacts;
        }

        // DELETE: api/Contacts/5
        public int Delete(int id)
        {
            int deletedContacts = _service.Remove(id);
            return deletedContacts;
        }
    }
}
