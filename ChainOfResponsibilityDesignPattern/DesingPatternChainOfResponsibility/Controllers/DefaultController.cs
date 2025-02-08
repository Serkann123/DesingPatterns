using DesingPatternChainOfResponsibility.ChainOfResponsibility;
using DesingPatternChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesingPatternChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee managerAssistant = new ManagerAssistant();
            Employee areaDirectory = new AreaDirectory();
            Employee manager = new Manager();

            treasurer.SetNextApprover(managerAssistant);
            managerAssistant.SetNextApprover(manager);
            manager.SetNextApprover(areaDirectory);

            treasurer.ProcessReques(model);

            return View();
        }
    }
}
