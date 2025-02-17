using DesignPattern.Meditor.MeditorPattern.Results;
using MediatR;
using System.Collections.Generic;

namespace DesignPattern.Meditor.MeditorPattern.Queries
{
    public class GetAllProductQuery:IRequest<List<GetAllProductQueryResult>>
    {
    }
}
