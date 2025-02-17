using DesignPattern.Meditor.DAL;
using DesignPattern.Meditor.MeditorPattern.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern.Meditor.MeditorPattern.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Products.Find(request.ProductId);
            values.ProductName = request.ProductName;
            values.ProductPrice = request.ProductPrice;
            values.ProductStock = request.ProductStock;
            values.ProductCategory = request.ProductCategory;
            values.ProductStockType = request.ProductStockType;
            await _context.SaveChangesAsync();
        }
    }
}
