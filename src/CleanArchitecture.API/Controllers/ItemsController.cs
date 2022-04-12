using CleanArchitecture.Application.ItemsAggregate.Queries;
using CleanArchitecture.Application.ItemsAggregate.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Controllers
{
    public class ItemsController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ItemResponse>> GetItems()
        {
            var result = await Mediator.Send(new GetItemQuery());
            return Ok(result);
        }
    }
}
