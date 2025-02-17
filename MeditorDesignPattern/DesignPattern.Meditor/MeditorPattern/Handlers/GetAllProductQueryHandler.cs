using DesignPattern.Meditor.DAL;
using DesignPattern.Meditor.MeditorPattern.Queries;
using DesignPattern.Meditor.MeditorPattern.Results;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern.Meditor.MeditorPattern.Handlers
{
    public class GetAllProductQueryHandler:IRequestHandler<GetAllProductQuery,List<GetAllProductQueryResult>>
    {
        private readonly Context _context;

        public GetAllProductQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<List<GetAllProductQueryResult>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products.Select(x => new GetAllProductQueryResult
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductCategory = x.ProductCategory,
                ProductPrice= x.ProductPrice,
                ProductStock= x.ProductStock,
                ProductStockType = x.ProductStockType
            }).ToListAsync();
        }
    }
}