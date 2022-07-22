using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCDb.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace MVCDb.Controllers
{
    public class EmpController : Controller
    {
        _1026dbContext db = new _1026dbContext();
        public IActionResult List()
        {
            return View(db.Emps.Include("Dept").ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Deptid = new SelectList(db.Depts, "Id", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Emp emp)
        {
            if (ModelState.IsValid)
            {
                db.Emps.Add(emp);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            ViewBag.Deptid = new SelectList(db.Depts, "Id", "Name");
            return View(emp);
        }
    }
}
