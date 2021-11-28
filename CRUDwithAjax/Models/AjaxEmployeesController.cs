using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDwithAjax.Models
{
    public class AjaxEmployeesController : Controller
    {
        DbdataModel db = new DbdataModel();
        // GET: AjaxEmployees
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetAll()
        {
            return Json(db.Employees.ToList(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetById( int id)
        {
            return Json(db.Employees.Find(id), JsonRequestBehavior.AllowGet);
        }
        public JsonResult Save(Employees employee)
        {
            db.Employees.Add(employee);
            db.SaveChanges();
            return Json(employee, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Update(Employees employee)
        {
            db.Entry(employee).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Json(employee, JsonRequestBehavior.AllowGet);
        }
        public JsonResult Delete(int id)
        {
            var emp = db.Employees.Find(id);
            db.Employees.Remove(emp);
            db.SaveChanges();
            return Json(emp, JsonRequestBehavior.AllowGet);
        }
    }
}