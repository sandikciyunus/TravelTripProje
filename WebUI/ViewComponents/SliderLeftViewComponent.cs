using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Models;

namespace WebUI.ViewComponents
{
    [ViewComponent]
    public class SliderLeftViewComponent:ViewComponent
    {
        private IBlogService _blogService;
        public SliderLeftViewComponent(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IViewComponentResult Invoke()
        {
            var model = new BlogListViewModel
            {
                LastBlogs = _blogService.SliderLastBlogs()
            };
            return View(model);
           
        }
    }
}
