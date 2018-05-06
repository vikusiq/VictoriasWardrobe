using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VictoriasWardrobe.Data.Entities;

namespace VictoriasWardrobe.Controllers
{
    public class HomeController : Controller
    {
        //Repository<Persons, VictoriasWardrobeDatabase> persons = new Repository<Persons, VictoriasWardrobeDatabase>(new VictoriasWardrobeDatabaseFactory());


        public ActionResult Index()
        {
            //persons.ExecuteCommand("insert into Persons values ('LastName','FirstName','Address','City')");
            return View();
        }
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View(); 
        }
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Women()
        {
            return View();
        }

    }
}