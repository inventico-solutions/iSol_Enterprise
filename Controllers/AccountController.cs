using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iSol_Enterprise.Models;
using Microsoft.AspNetCore.Mvc;

namespace iSol_Enterprise.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Account User)
        {
            return RedirectToAction("AllUsers", "Dashboard");
        }

    }
}