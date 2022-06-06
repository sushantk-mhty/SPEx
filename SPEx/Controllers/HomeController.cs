using SPEx.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPEx.Controllers
{
    public class HomeController : Controller
    {
        private DbContextEntities db;
        public HomeController()
        {
            db = new DbContextEntities();
        }
        public ActionResult Index()
        {
            var data = db.Database.SqlQuery<tblLogin>("exec login.Usp_GetLogin").ToList();
            return View(data);
        }

        public ActionResult Details(int id)
        {
            SqlParameter param = new SqlParameter("@id", id);
            var data = db.Database.SqlQuery<tblLogin>("exec login.Usp_GetLoginById @id", param).SingleOrDefault();
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tblLogin obj)
        {
            try
            {
                string toDayDate = DateTime.Now.ToString("dd-MMM-yyyy");
                SqlParameter[] param = new SqlParameter[]
               {
                new SqlParameter("@UserName",obj.UserName??(object)DBNull.Value),
                new SqlParameter("@Password",obj.password??(object)DBNull.Value),
                new SqlParameter("@LastLogin",toDayDate??(object)DBNull.Value)
               };
                var data = db.Database.ExecuteSqlCommand("login.Usp_InsertLogin @UserName,@Password,@LastLogin", param);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            SqlParameter param = new SqlParameter("@id", id);
            var data = db.Database.SqlQuery<tblLogin>("exec login.Usp_GetLoginById @id", param).SingleOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(int? id,tblLogin obj)
        {
            try
            {
                SqlParameter[] param = new SqlParameter[]
               {
                new SqlParameter("@UserName",obj.UserName??(object)DBNull.Value),
                new SqlParameter("@Password",obj.password??(object)DBNull.Value),
                new SqlParameter("@id",id??(object)DBNull.Value)
               };
                var data = db.Database.ExecuteSqlCommand("login.Usp_UpdateLogin @id, @UserName,@Password", param);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            SqlParameter param = new SqlParameter("@id", id);
            var data = db.Database.SqlQuery<tblLogin>("exec login.Usp_GetLoginById @id", param).SingleOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Delete(int id, tblLogin obj)
        {
            SqlParameter param = new SqlParameter("@id", id);
            db.Database.ExecuteSqlCommand("login.Usp_DeleteLogin @id", param);
            return RedirectToAction(nameof(Index));
        }
    }
}