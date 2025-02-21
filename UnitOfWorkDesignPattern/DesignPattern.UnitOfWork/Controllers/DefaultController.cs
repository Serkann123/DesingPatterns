using DesignPattern.BusinessLayer.Abstract;
using DesignPattern.EntityLayer.Concrete;
using DesignPattern.UnitOfWork.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DesignPattern.UnitOfWork.Controllers
{
    public class DefaultController : Controller
    {

        private readonly ICustomerService _customerService;

        public DefaultController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerViewModel model)
        {
            var values1 = _customerService.TGetById(model.SenderId);
            var values2 = _customerService.TGetById(model.ReceiverId);

            values1.CustomerBalance -= model.Amount;
            values2.CustomerBalance += model.Amount;

            List<Customer> customers = new List<Customer>()
            {
                values1,
                values2
            };

            _customerService.TMultiUpdate(customers);

            return View();
        }
    }
}
