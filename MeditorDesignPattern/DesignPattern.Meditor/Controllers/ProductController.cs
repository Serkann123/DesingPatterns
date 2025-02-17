using DesignPattern.Meditor.MeditorPattern.Commands;
using DesignPattern.Meditor.MeditorPattern.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DesignPattern.Meditor.Controllers
{
    public class ProductController : Controller
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllProductQuery());
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> GetProduct(int id, bool showUpdateButton = true)
        {
            var values = await _mediator.Send(new GetProductByIdQuery(id));
            ViewBag.ShowUpdateButton = showUpdateButton;
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> RemoveProduct(int id)
        {
            await _mediator.Send(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommand command)
        {
            await _mediator.Send(command);
            return RedirectToAction("Index");
        }
    }
}