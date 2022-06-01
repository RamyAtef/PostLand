using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using PostLand.Application.Features.Post.Queries.GetPostList;
using PostLand.Domain;

namespace PostLand.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Post, GetPostsListViewModel>().ReverseMap();
           // CreateMap<Post, GetPostDetailViewModel>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            //CreateMap<Post, CreatePostCommand>().ReverseMap();
            //CreateMap<Post, UpdatePostCommand>().ReverseMap();
            //CreateMap<Post, DeletePostCommand>().ReverseMap();
        }
    }
}
