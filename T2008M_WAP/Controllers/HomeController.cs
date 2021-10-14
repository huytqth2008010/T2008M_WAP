using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using T2008M_WAP.Models;
namespace T2008M_WAP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Product()
        {
            DataContext dc = new DataContext();
            List<Product> products = dc.Products.ToList();
            return View(products);
        }
        public ActionResult Category()
        {
            DataContext dc = new DataContext();
            List<Category> categories = dc.Categories.ToList();
            //List<Category> categories = new List<Category>();
            //categories.Add(new Category() { Name = "Fashions" });
            return View(categories);
        }
        public ActionResult Brand()
        {
            DataContext dc = new DataContext();
            List<Brand> brands = dc.Brands.ToList();
            //List<Brand> brands = new List<Brand>();
            //categories.Add(new Category() { Name = "Fashions" });
            return View(brands);
        }
    }
}