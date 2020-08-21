using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Dto.Concrete.YorumDto;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    [EnableCors]
    public class YorumController : Controller
    {
        private IYorumService _yorumService;
        private IMapper _mapper;
        public YorumController(IYorumService yorumService,IMapper mapper)
        {
            _yorumService = yorumService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View(new YorumListViewModel { 
            Yorums=_yorumService.GetAllWithTable()
            });
        }

        public IActionResult Sil(int id)
        {
            var yorum = _yorumService.GetById(id);
            _yorumService.Delete(yorum.Id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            var yorum = _yorumService.GetById(id);
            return View(new YorumUpdateViewModel
            {
                Id=yorum.Id,
                KullaniciAdi=yorum.KullaniciAdi,
                Mail=yorum.Mail,
                BlogId=yorum.BlogId,
               Yorumm=yorum.Yorumm
            });
        }
        [HttpPost]
        public IActionResult Guncelle(YorumUpdateDto yorumUpdateDto)
        {
            if(ModelState.IsValid)
            {
                _yorumService.Update(_mapper.Map<Yorum>(yorumUpdateDto));
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
