using IpaBisikletaMo_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitOfWork;

namespace IpaBisikletaMo_Application.Controllers
{
    public class LoginController : Controller
    {
        GenericUnitOfWork _unitOfWork;
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateAccount(LoginModel items)
        {
            _unitOfWork = new GenericUnitOfWork();
            if (ModelState.IsValid)
            {
                LoginModel.CreateAccount(items, _unitOfWork);
                return RedirectToAction("Index");
            }

            return View(items);
        }
    }
}