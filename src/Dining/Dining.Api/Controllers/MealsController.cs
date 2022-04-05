namespace Dining.Api.Controllers
{
    using Dining.Models.DataTransferObjects;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    public class MealsController : ControllerBase
    {
        private readonly IMediator mediator;
        public MealsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("GetMenu")]
        public async Task<IActionResult> GetMenu()
        {
            return this.Ok(await mediator.Send(new MenuRequestDTO()));
        }
    }
}
