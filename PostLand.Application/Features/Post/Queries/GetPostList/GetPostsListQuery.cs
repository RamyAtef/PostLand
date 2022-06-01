using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace PostLand.Application.Features.Post.Queries.GetPostList
{
    public class GetPostsListQuery : IRequest<List<GetPostsListViewModel>>
    {

    }
}
