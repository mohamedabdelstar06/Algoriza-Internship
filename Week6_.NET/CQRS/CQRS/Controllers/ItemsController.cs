using CQRS_lib.CQRS.Commands;
using CQRS_lib.CQRS.Queries;
using CQRS_lib.Data.Models;
using CQRS_lib.Repos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ItemsController : ControllerBase
{
    public ItemsController(IItemsRepo repo , IMediator mediator)
    {
        _repo = repo;
        _mediator = mediator;
    }

    private readonly IItemsRepo _repo;
    private readonly IMediator _mediator;


    [HttpGet]
    public async Task<IActionResult> GetItems()
    {
        var result = await _mediator.Send( new GetAllItemsQuery());
        return Ok(result);
    }

    [HttpPost]
    public async Task <IActionResult> InsertItem(Items item)
    {
        var result = await _mediator.Send(new InsertItemCommand(item));
        return Ok(result);
    }
}
