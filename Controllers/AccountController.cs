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
            object confirm = Array("Welcome To iSOl Enterprise","");
            return View();
        }
        [HttpPost]
        public IActionResult Index(Account User)
        {
            var verify =_db.Users.Where(x => x.Email == User.Email && x.Password == User.Password).FirstOrDefault();
            if (verify != null)
            {
                ViewData["Message"] = "Login was successfull";
                return View();
            }
            else
            {
                ViewData["Message"] = "Wrong Email or Password";
                return View();
            }
        }

    }
}