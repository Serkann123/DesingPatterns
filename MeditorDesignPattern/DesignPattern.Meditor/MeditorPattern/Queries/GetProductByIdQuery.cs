using DesignPattern.Meditor.MeditorPattern.Results;
using MediatR;

namespace DesignPattern.Meditor.MeditorPattern.Queries
{
    public class GetProductByIdQuery:IRequest<GetProductByIdQueryResult>
    {
        public int Id { get; set; }
        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}
