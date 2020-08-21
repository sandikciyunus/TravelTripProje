using AutoMapper;
using Dto.Concrete.BlogDto;
using Dto.Concrete.YorumDto;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<BlogAddDto, Blog>();
            CreateMap<Blog, BlogAddDto>();

            CreateMap<BlogUpdateDto, Blog>();
            CreateMap<Blog, BlogUpdateDto>();

            CreateMap<YorumListDto, Yorum>();
            CreateMap<Yorum, YorumListDto>();

            CreateMap<YorumAddDto, Yorum>();
            CreateMap<Yorum, YorumAddDto>();

            CreateMap<YorumUpdateDto, Yorum>();
            CreateMap<Yorum, YorumUpdateDto>();
        }
    }
}
