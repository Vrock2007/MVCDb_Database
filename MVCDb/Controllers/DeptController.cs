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
    }
}
