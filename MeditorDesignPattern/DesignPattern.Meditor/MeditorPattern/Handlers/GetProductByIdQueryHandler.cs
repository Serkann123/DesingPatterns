using DesignPattern.Meditor.DAL;
using DesignPattern.Meditor.MeditorPattern.Queries;
using DesignPattern.Meditor.MeditorPattern.Results;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern.Meditor.MeditorPattern.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Products.FindAsync(request.Id);
            return new GetProductByIdQueryResult
            {
                ProductId = values.ProductId,
                ProductName = values.ProductName,
                ProductStock = values.ProductStock,
                ProductPrice = values.ProductPrice,
                ProductCategory = values.ProductCategory,
                ProductStockType = values.ProductStockType
            };
        }
    }
}
