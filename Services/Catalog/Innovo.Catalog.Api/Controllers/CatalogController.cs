namespace Innovo.Catalog.Api.Controllers
{
    using Innovo.Catalog.Api.Application.Commands;
    using Innovo.Catalog.Api.Application.Queries;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;



    [Route("api")]
    [ApiController]
    public class CatalogController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator mediator = mediator;


        [HttpGet]
        [Produces("application/json")]
        [Route("{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            var result = await this.mediator.Send(new GetProductByIdQuery(id));
            return CreatedAtAction(nameof(GetProductById),
                                  new { id = result }, result);
        }

        [HttpPost]
        [Produces("application/json")]
        [Route("api/catalog")]
        public async Task<IActionResult> Create()
        {
            var result = await this.mediator.Send(new CreateCatalogCommand());
            return CreatedAtAction(nameof(GetProductById),
                                  new {id = result}, result);
        }

    }
}
