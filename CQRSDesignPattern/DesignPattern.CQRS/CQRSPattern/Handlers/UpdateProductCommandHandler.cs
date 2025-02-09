using DesignPattern.CQRS.CQRSPattern.Commands;
using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Set<Product>().Find(command.ProductId);
            values.Stock = command.Stock;
            values.Price = command.Price;
            values.Status = true;
            values.Description = command.Description;
            values.Name = command.Name;
            _context.SaveChanges();
        }
    }
}
