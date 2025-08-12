

using CQRS_lib.CQRS.Queries;
using CQRS_lib.Data.Models;
using CQRS_lib.Data;
using MediatR;

namespace CQRS_lib.CQRS.Handelers;
public class GetItemsListHandler : IRequestHandler<GetAllItemsQuery, List<Items>>
{
    ApplicationDbContext _db;
    public GetItemsListHandler (ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task<List<Items>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
    {
        return await Task.FromResult(_db.Items.ToList());
    }
}
