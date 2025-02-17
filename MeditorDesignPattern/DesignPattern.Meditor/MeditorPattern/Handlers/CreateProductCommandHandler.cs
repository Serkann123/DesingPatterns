using DesignPattern.Meditor.DAL;
using DesignPattern.Meditor.MeditorPattern.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern.Meditor.MeditorPattern.Handlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly Context _context;

        public CreateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            _context.Products.Add(new Product
            {
                ProductCategory = request.ProductCategory,
                ProductName = request.ProductName,
                ProductPrice = request.ProductPrice,
                ProductStock = request.ProductStock,
                ProductStockType = request.ProductStockType,
            });

           await _context.SaveChangesAsync();
        }
    }
}
