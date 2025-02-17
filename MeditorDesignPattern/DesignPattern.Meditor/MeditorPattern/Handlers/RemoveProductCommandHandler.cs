using DesignPattern.Meditor.DAL;
using DesignPattern.Meditor.MeditorPattern.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPattern.Meditor.MeditorPattern.Handlers
{
    public class RemoveProductCommandHandler : IRequestHandler<RemoveProductCommand>
    {
        private readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task Handle(RemoveProductCommand request, CancellationToken cancellationToken)
        {
            var values = _context.Products.Find(request.Id);
            _context.Remove(values);
            await _context.SaveChangesAsync();
        }
    }
}
