using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VictoriasWardrobe.Data.Databases;
using VictoriasWardrobe.Data.Entities;
using VictoriasWardrobe.Data.Infrastructure;
using VictoriasWardrobe.Models;

namespace VictoriasWardrobe.Controllers
{
    public class HomeController : Controller
    {
        Repository<Brand, VictoriasWardrobeDatabase> brands = new Repository<Brand, VictoriasWardrobeDatabase>(new VictoriasWardrobeDatabaseFactory());
        Repository<Users, VictoriasWardrobeDatabase> users  = new Repository<Users, VictoriasWardrobeDatabase>(new VictoriasWardrobeDatabaseFactory());


        public ActionResult Index()
        {
            //brands.ExecuteCommand("insert into brand values('test')");
            // var brandsCount = brands.ExecuteQuery<int>("select count(*) from brand");

           // users.ExecuteCommand("insert into users(email_address, password, fisrt_name, last_name) values ('vasile@mail.ru','454545', 'Vasile', 'Roman');");

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

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Users user)
        {
            
            users.ExecuteCommand("insert into users(email_address, password, fisrt_name, last_name) values ('" + user.email_address + " ',' " + user.password +  " ',' " + user.first_name + " ',' " + user.last_name +"');");
            return View();
        }

        public ActionResult Women()
        {
            return View();
        }

        public ActionResult Login(UserCredentials userCredentials)
        {
           

            return View("Index");
        }

        [HttpGet]
        public ActionResult MyProfile()
        {
            return View("MyProfile");
        }

        [HttpPost]
        public ActionResult MyProfile(User_Details userDetails)
        {
            return View();
        }

    }
}