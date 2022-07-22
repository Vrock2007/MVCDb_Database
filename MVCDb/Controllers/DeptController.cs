using Microsoft.AspNetCore.Mvc;
using MVCDb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MVCDb.Controllers
{
    public class DeptController : Controller
    {
        IDept repos = null;
        public DeptController(IDept _repos)
        {
            repos = _repos;
        }
        public IActionResult List()
        {
            return View(repos.GetDepts().ToList());
        }
        public IActionResult Details(int id)
        {
            var data = repos.Find(id);
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Dept dept)
        {
            // check model and then only save..else stay
            if (ModelState.IsValid)
            {
                repos.AddDept(dept);
                return RedirectToAction("List");
            }
            return View(dept); 
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Dept dept = repos.Find(id);
            return View(dept);
        }
        [HttpPost]
        public IActionResult Edit(Dept dept)
        {
            if (ModelState.IsValid)
            {
                repos.EditDept(dept);
                return RedirectToAction("List");
            }
            return View(dept);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Dept dept = repos.Find(id);
            return View(dept);
        }
        [HttpPost]
        public IActionResult Delete(Dept dept)
        {
            repos.DeleteDept(dept.Id);
            return RedirectToAction("List");
        }
    }
}
