﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Evolent
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EvolentDBEntities : DbContext
    {
        public EvolentDBEntities()
            : base("name=EvolentDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual int EvolentContactsCRUD(Nullable<int> id, string first_name, string last_name, string email, string mobile, string status, string statementType)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var first_nameParameter = first_name != null ?
                new ObjectParameter("first_name", first_name) :
                new ObjectParameter("first_name", typeof(string));
    
            var last_nameParameter = last_name != null ?
                new ObjectParameter("last_name", last_name) :
                new ObjectParameter("last_name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("mobile", mobile) :
                new ObjectParameter("mobile", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            var statementTypeParameter = statementType != null ?
                new ObjectParameter("StatementType", statementType) :
                new ObjectParameter("StatementType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EvolentContactsCRUD", idParameter, first_nameParameter, last_nameParameter, emailParameter, mobileParameter, statusParameter, statementTypeParameter);
        }
    
        public virtual int CreateContact(string first_name, string last_name, string email, string mobile, string status)
        {
            var first_nameParameter = first_name != null ?
                new ObjectParameter("first_name", first_name) :
                new ObjectParameter("first_name", typeof(string));
    
            var last_nameParameter = last_name != null ?
                new ObjectParameter("last_name", last_name) :
                new ObjectParameter("last_name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("mobile", mobile) :
                new ObjectParameter("mobile", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateContact", first_nameParameter, last_nameParameter, emailParameter, mobileParameter, statusParameter);
        }
    
        public virtual int DeleteContact(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteContact", idParameter);
        }
    
        public virtual ObjectResult<GetAllContacts_Result> GetAllContacts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllContacts_Result>("GetAllContacts");
        }
    
        public virtual ObjectResult<GetContact_Result> GetContact(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetContact_Result>("GetContact", idParameter);
        }
    
        public virtual int UpdateContact(Nullable<int> id, string first_name, string last_name, string email, string mobile, string status)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var first_nameParameter = first_name != null ?
                new ObjectParameter("first_name", first_name) :
                new ObjectParameter("first_name", typeof(string));
    
            var last_nameParameter = last_name != null ?
                new ObjectParameter("last_name", last_name) :
                new ObjectParameter("last_name", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("mobile", mobile) :
                new ObjectParameter("mobile", typeof(string));
    
            var statusParameter = status != null ?
                new ObjectParameter("status", status) :
                new ObjectParameter("status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateContact", idParameter, first_nameParameter, last_nameParameter, emailParameter, mobileParameter, statusParameter);
        }
    }
}