using MVCA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCA.Controllers
{
    public class TimesheetController : Controller
    {
        //
        // GET: /timesheet/

    
        public ActionResult Index()
        {
            using (var db = new Timesheet1())
            {
                return View(db.entry.ToList());
            }

            //return View();
           
        }
        [HttpPost]
        public ActionResult add(Timesheet sheet)
        {
            try
     {
         using (var db = new Timesheet1())
         {
             db.entry.Add(sheet);
              db.SaveChanges();
         }
         return RedirectToAction("Index");
      }
      catch
      {
        return View();
      }
        }
        //[HttpPost]
       // public ActionResult Index(timesheet sheet)
        //{
          //  try
            //{
              //  if (ModelState.IsValid)
                //{
                  //  manager userManager = new manager();
                    
                    //    return RedirectToAction("Welcome", "Home");
                   
                //}
            //}
            //catch
           // {
             //   return View(sheet);
            //}

          //  return View(sheet);
        //}
       
	}
}