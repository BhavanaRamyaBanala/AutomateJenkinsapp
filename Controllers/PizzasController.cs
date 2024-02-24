using AutomateJenkinsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomateJenkinsApp.Controllers
{
    public class PizzasController : Controller
    {
        static List<Pizza> pizzas = new List<Pizza>() { 
            new Pizza { Id = 1,Name="Paneer pizza",Price=650},
            new Pizza { Id = 2,Name="Mushroom pizza",Price=550},
            new Pizza { Id = 3,Name="Chicken pizza",Price=850},
        };
        // GET: Pizzas
        public ActionResult Index()
        {
            return View(pizzas);
        }
    }
}