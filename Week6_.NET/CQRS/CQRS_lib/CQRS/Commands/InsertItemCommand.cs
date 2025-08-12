

using CQRS_lib.Data.Models;
using MediatR;

namespace CQRS_lib.CQRS.Commands;
public record InsertItemCommand(Items item) : IRequest<Items> 
{
}
