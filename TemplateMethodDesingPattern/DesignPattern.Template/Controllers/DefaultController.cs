using DesignPattern.Template.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Template.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicIndex()
        {
            NetflixPlan netflixPlan = new BasicPlan();
            ViewBag.v1 = netflixPlan.PlanType("Temel Plan");
            ViewBag.v2 = netflixPlan.CountPerson(1);
            ViewBag.v3 = netflixPlan.Price(65.99);
            ViewBag.v4 = netflixPlan.Content("Film-Dizi");
            ViewBag.v5 = netflixPlan.Resulition("480px");

            return View();
        }

        public IActionResult StandartIndex()
        {
            NetflixPlan netflixPlan = new StandartPlan();
            ViewBag.v1 = netflixPlan.PlanType("Standart Plan");
            ViewBag.v2 = netflixPlan.CountPerson(2);
            ViewBag.v3 = netflixPlan.Price(94.99);
            ViewBag.v4 = netflixPlan.Content("Film-Dizi-Animasyon");
            ViewBag.v5 = netflixPlan.Resulition("720px");

            return View();
        }

        public IActionResult UltraIndex()
        {
            NetflixPlan netflixPlan = new UltraPlan();
            ViewBag.v1 = netflixPlan.PlanType("Ultra Plan");
            ViewBag.v2 = netflixPlan.CountPerson(3);
            ViewBag.v3 = netflixPlan.Price(134.99);
            ViewBag.v4 = netflixPlan.Content("Film-Dizi-Animasyon-Belgesel");
            ViewBag.v5 = netflixPlan.Resulition("108px");

            return View();
        }
    }
}
