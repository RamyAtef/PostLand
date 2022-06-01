using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PostLand.Application.Features.Post.Queries.GetPostList;

namespace PostLand.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllPosts")]
        public async Task<ActionResult<List<GetPostsListViewModel>>> GetAllPosts()
        {
            var dtos = await _mediator.Send(new GetPostsListQuery());
            return Ok(dtos);
        }
    }
}
