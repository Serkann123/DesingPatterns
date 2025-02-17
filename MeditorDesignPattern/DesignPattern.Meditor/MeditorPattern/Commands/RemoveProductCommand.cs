using MediatR;

namespace DesignPattern.Meditor.MeditorPattern.Commands
{
    public class RemoveProductCommand : IRequest
    {
        public int Id { get; set; }
        public RemoveProductCommand(int id)
        {
            Id = id;
        }
    }
}
