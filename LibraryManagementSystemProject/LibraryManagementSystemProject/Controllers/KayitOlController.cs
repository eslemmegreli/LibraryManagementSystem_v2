using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryManagementSystemProject.Models.Entity;

namespace LibraryManagementSystemProject.Controllers
{
    [AllowAnonymous]   //Authentication işlemini devre dışı bırakır
    public class KayitOlController : Controller
    {

        dbKUTUPHANEEntities db = new dbKUTUPHANEEntities();
        // GET: KayitOl

        [HttpGet]
        public ActionResult Kayit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Kayit(TBLUYELER p)
        {
            if (!ModelState.IsValid)   //model geçerli değilse (yani, geçerlilik kontrollerinden biri başarısız olduysa)
            {
                return View("Kayit");  //kayit'a dön
            }
            db.TBLUYELER.Add(p);
            db.SaveChanges();
            return View();
        }
    }
}