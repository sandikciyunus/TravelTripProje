using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Dto.Concrete.BlogDto;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    [Authorize(Roles ="Admin")]
    [EnableCors]
    public class AdminController : Controller
    {
        private IBlogService _blogService;
        private IHakkimizdaService _hakkimizdaService;
        private IMapper _mapper;
        private SignInManager<AppUser> _signInManager;
        public AdminController(IBlogService blogService,IHakkimizdaService hakkimizdaService,IMapper mapper,SignInManager<AppUser> signInManager)
        {
            _blogService = blogService;
            _hakkimizdaService = hakkimizdaService;
            _mapper = mapper;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View(new BlogListViewModel 
            { 
                Blogs=_blogService.GetAll()
            });
        }

        [HttpGet]
        public IActionResult YeniBlog()
        {
            return View();
        }

        [HttpPost]
        public IActionResult YeniBlog(BlogAddDto blogAddDto)
        {
            if(ModelState.IsValid)
            {
                _blogService.Add(_mapper.Map<Blog>(blogAddDto));
                return RedirectToAction("Index");
            }
            return View();
        }


        [HttpGet]
        public IActionResult BlogGuncelle(int id)
        {
            var blog = _blogService.GetById(id);
            return View(new BlogUpdateViewModel
            {
                Id = blog.Id,
                Aciklama = blog.Aciklama,
                Baslik = blog.Baslik,
                BlogImage = blog.BlogImage
            });
        }

        [HttpPost]
        public IActionResult BlogGuncelle(BlogUpdateDto blogUpdateDto)
        {
            if(ModelState.IsValid)
            {
                _blogService.Update(_mapper.Map<Blog>(blogUpdateDto));
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult BlogSil(int id)
        {
            var blog = _blogService.GetById(id);
            _blogService.Delete(blog.Id);
            return RedirectToAction("Index");
        }

        public IActionResult Hakkimizda()
        {
            return View(new HakkimizdaListViewModel
            {
                Hakkimizdas = _hakkimizdaService.GetAll()
            });
        }

        [HttpGet]
        public IActionResult HakkimizdaGuncelle(int id)
        {
            return View(new HakkimizdaUpdateViewModel
            {
                Hakkimizda = _hakkimizdaService.GetById(id)
            });
        }

        [HttpPost]
        public IActionResult HakkimizdaGuncelle(Hakkimizda hakkimizda)
        {
            if(ModelState.IsValid)
            {
                _hakkimizdaService.Update(hakkimizda);
                return RedirectToAction("Hakkimizda");
            }
            return View();
        }


        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("GirisYap", "Login");
        }
    }
}
