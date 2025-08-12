using CQRS_lib.Data.Models;
using MediatR;

namespace CQRS_lib.CQRS.Queries;
public record GetAllItemsQuery : IRequest<List<Items>>
{

}
