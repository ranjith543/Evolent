using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Evolent.Models;
using System.Threading.Tasks;

namespace Evolent.Services
{
    public class ContactRepository : IContactRepository
    {
        int status = 0;
        public Contact Add(Contact contact)
        {
            try
            {
                using (EvolentDBEntities context = new EvolentDBEntities())
                {
                    status = context.CreateContact(contact.FirstName, contact.LastName, contact.Email, contact.Phone, contact.IsActive == true ? "true" : "false");
                }
            }
            catch(Exception ex)
            {
                throw ex;
                    //TODO:
                //ViewBag["Error"] = ex.Message.ToString();
            }
            return contact;
        }

        private Contact BuildContact(GetContact_Result contact)
        {
            Contact contactBuild = new Contact();
            try
            { 
            contactBuild.Id = contact.ContactID;
            contactBuild.FirstName = contact.FirstName;
            contactBuild.LastName = contact.LastName;
            contactBuild.Email = contact.Email;
            contactBuild.Phone = contact.Phone;
            contactBuild.IsActive = contact.IsActive.ToLower() == "true" ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
                //Handle Ex
            }
            return contactBuild;
        }

        private Contact BuildContactForList(GetAllContacts_Result contact)
        {
            Contact contactBuild = null;
            try
            {
            contactBuild = new Contact();
            contactBuild.Id = contact.ContactID;
            contactBuild.FirstName = contact.FirstName;
            contactBuild.LastName = contact.LastName;
            contactBuild.Email = contact.Email;
            contactBuild.Phone = contact.Phone;
            contactBuild.IsActive = contact.IsActive.ToLower() == "true" ? true : false;
            }
            catch (Exception ex)
            {
                throw ex;
                //Handle Ex
            }
            return contactBuild;
        }

        public Contact Get(int id)
        {
            Contact fetchedContact = null;
            try
            {
                fetchedContact = new Contact();
                using (EvolentDBEntities context = new EvolentDBEntities())
                {
                    var contact = context.GetContact(id);
                    
                    fetchedContact = BuildContact(contact.Single());
                }
            }
            catch (Exception ex)
            {
                throw ex;
                //Handle Ex
            }
            return fetchedContact;
        }

        public IEnumerable<Contact> GetAll()
        {
            List<Contact> contacts;
            try
            {
                 contacts = new List<Contact>();
                using (EvolentDBEntities context = new EvolentDBEntities())
                {
                    var records = context.GetAllContacts().ToList();

                    if (records.Any())
                    {
                        contacts = records.Select(BuildContactForList).ToList();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return contacts;
        }

        public int Remove(int id)
        {
            try
            {
                using (EvolentDBEntities context = new EvolentDBEntities())
                {
                    status = context.DeleteContact(id);
                }
            }
            catch(Exception ex)
            {
                //TODO:
            }
            return status;
        }

        public int Update(Contact contact)
        {
            try
            {
                using (EvolentDBEntities context = new EvolentDBEntities())
                {
                    status = context.UpdateContact(contact.Id, contact.FirstName, contact.LastName, contact.Email, contact.Phone, contact.IsActive == true ? "true" : "false");
                }
            }
            catch(Exception ex)
            {
                throw ex;
                //TODO:
            }
            return status;
        }
    }
}