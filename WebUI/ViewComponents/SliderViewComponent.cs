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
    public class SliderViewComponent:ViewComponent
    {
        private IBlogService _blogService;
        public SliderViewComponent(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IViewComponentResult Invoke()
        {
            var model = new BlogListViewModel
            {
                LastBlogs = _blogService.SliderLastBlogs2()
            };
            return View(model);
           
        }
    }
}
