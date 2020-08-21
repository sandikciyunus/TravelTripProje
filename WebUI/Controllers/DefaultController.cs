using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    [EnableCors]
    public class DefaultController : Controller
    {
        private IBlogService _blogService;
        public DefaultController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public IActionResult Index()
        {
            return View(new BlogListViewModel
            {
                Blogs=_blogService.GetAll(),
                LastBlogs=_blogService.LastBlogs(),
                TenBlogs=_blogService.TenBlogs(),
                LastSixBlogs=_blogService.LastSixBlogs()
            });
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
