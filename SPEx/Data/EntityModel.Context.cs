﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPEx.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbContextEntities : DbContext
    {
        public DbContextEntities()
            : base("name=DbContextEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblLogin> tblLogins { get; set; }
    
        public virtual ObjectResult<Usp_GetCategoryById_Result> Usp_GetCategoryById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Usp_GetCategoryById_Result>("Usp_GetCategoryById", idParameter);
        }
    
        public virtual ObjectResult<Usp_GetDataByIdName_Result> Usp_GetDataByIdName(Nullable<int> id, string name)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Usp_GetDataByIdName_Result>("Usp_GetDataByIdName", idParameter, nameParameter);
        }
    
        public virtual int Usp_InsertDataCategory(string categoryname)
        {
            var categorynameParameter = categoryname != null ?
                new ObjectParameter("categoryname", categoryname) :
                new ObjectParameter("categoryname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Usp_InsertDataCategory", categorynameParameter);
        }
    
        public virtual int Usp_InsertDataPOST(Nullable<int> postweight, string postman, Nullable<int> categoryid)
        {
            var postweightParameter = postweight.HasValue ?
                new ObjectParameter("postweight", postweight) :
                new ObjectParameter("postweight", typeof(int));
    
            var postmanParameter = postman != null ?
                new ObjectParameter("postman", postman) :
                new ObjectParameter("postman", typeof(string));
    
            var categoryidParameter = categoryid.HasValue ?
                new ObjectParameter("categoryid", categoryid) :
                new ObjectParameter("categoryid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Usp_InsertDataPOST", postweightParameter, postmanParameter, categoryidParameter);
        }
    
        public virtual int Usp_DeleteLogin(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Usp_DeleteLogin", idParameter);
        }
    
        public virtual ObjectResult<Usp_GetLogin_Result> Usp_GetLogin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Usp_GetLogin_Result>("Usp_GetLogin");
        }
    
        public virtual ObjectResult<Usp_GetLoginById_Result> Usp_GetLoginById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Usp_GetLoginById_Result>("Usp_GetLoginById", idParameter);
        }
    
        public virtual int Usp_InsertLogin(string userName, string password, Nullable<System.DateTime> lastLogin)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var lastLoginParameter = lastLogin.HasValue ?
                new ObjectParameter("LastLogin", lastLogin) :
                new ObjectParameter("LastLogin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Usp_InsertLogin", userNameParameter, passwordParameter, lastLoginParameter);
        }
    
        public virtual int Usp_UpdateLogin(Nullable<int> id, string userName, string password)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Usp_UpdateLogin", idParameter, userNameParameter, passwordParameter);
        }
    }
}