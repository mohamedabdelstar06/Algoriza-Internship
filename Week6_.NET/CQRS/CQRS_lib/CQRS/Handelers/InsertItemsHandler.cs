
using CQRS_lib.CQRS.Commands;
using CQRS_lib.Data;
using CQRS_lib.Data.Models;
using MediatR;

namespace CQRS_lib.CQRS.Handelers;
public class InsertItemsHandler : IRequestHandler<InsertItemCommand, Items>
{

    ApplicationDbContext _db;
    public InsertItemsHandler (ApplicationDbContext db)
    {
        _db = db;
    }
    public async Task<Items> Handle(InsertItemCommand request, CancellationToken cancellationToken)
    {
       await  _db.Items.AddAsync(request.item);
        _db.SaveChanges();
        return await Task.FromResult(request.item);
    }
}
