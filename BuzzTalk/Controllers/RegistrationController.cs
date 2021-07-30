using BuzzTalk.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuzzTalk.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContext _db;
        [BindProperty]
        public User user { get; set; }
        public RegistrationController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
