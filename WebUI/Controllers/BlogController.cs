using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Dto.Concrete.YorumDto;
using Entities.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    [EnableCors]
    public class BlogController : Controller
    {
        private IBlogService _blogService;
        private IYorumService _yorumService;
        private IMapper _mapper;
        public BlogController(IBlogService blogService,IYorumService yorumService,IMapper mapper)
        {
            _blogService = blogService;
            _yorumService = yorumService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View(new BlogListViewModel 
            { 
                Blogs=_blogService.GetAll(),
                LastBlogs=_blogService.LastBlogs()
            });
        }

        public IActionResult BlogDetail(int id)
        {
            return View(new BlogDetayViewModel
            {
                Blog=_blogService.GetById(id),
                Yorums=_yorumService.GetByBlogId(id)
            });
        }

        [HttpPost]
        public IActionResult YorumYap(YorumAddDto yorumAddDto)
        {
            _yorumService.Add(_mapper.Map<Yorum>(yorumAddDto));
            return RedirectToAction("BlogDetail", new { id = yorumAddDto.BlogId });
        }
    }
}
