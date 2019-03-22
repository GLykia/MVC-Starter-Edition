using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Giris_Kontrol.Models;

namespace Giris_Kontrol.Controllers
{
    public class UserController : Controller
    {
        private static List<User> Kullanicilar;

        static UserController()
        {
            Kullanicilar = new List<Models.User>
            {
                new Models.User
                {
                    ID=Guid.NewGuid(),
                    Ad_Soyad="Emre Uzun",
                    KullaniciAdi="emre.uzun",
                    Parola="1234"
                }
            };
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Insert()
        {
            var model = new UserViewModel
            {
                user = new User()
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Insert(User user)
        {
            user.ID = Guid.NewGuid();
            Kullanicilar.Add(user);
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            return PartialView(User);
        }
    }
}