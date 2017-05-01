using Evolent.Models;
using Evolent.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Evolent.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Evolent Contacts Home";
            IContactRepository _service = new ContactRepository();
            List<Contact> contactList = new List<Contact>();
            contactList = _service.GetAll().ToList();
            return View(contactList);
        }

        public ActionResult Delete(int contactId)
        {
            ViewBag.Title = "Evolent Contacts Delete";
            IContactRepository _service = new ContactRepository();
            int count = _service.Remove(contactId);
            return View(count);
        }

        public ActionResult Edit(int contactId)
        {
            ViewBag.Title = "Evolent Contacts Edit";
            IContactRepository _service = new ContactRepository();
            Contact contact = _service.Get(contactId);
            return View("Update",contact);
        }

        public ActionResult Update(Contact contact)
        {
            ViewBag.Title = "Evolent Contacts Edit";
            IContactRepository _service = new ContactRepository();
            int count = _service.Update(contact);
            return View("UpdateMessage",count);
        }

        public ActionResult Add(Contact contact)
        {
            ViewBag.Title = "Evolent Contacts Edit";
            IContactRepository _service = new ContactRepository();
            _service.Add(contact);
            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}
