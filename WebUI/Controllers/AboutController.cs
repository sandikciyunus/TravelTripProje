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
    public class AboutController : Controller
    {
        private IHakkimizdaService _hakkimizdaService;
        public AboutController(IHakkimizdaService hakkimizdaService)
        {
            _hakkimizdaService = hakkimizdaService;
        }
        public IActionResult Index()
        {
            return View(new HakkimizdaListViewModel
            {
                Hakkimizdas = _hakkimizdaService.GetAll()
            });
        }
    }
}
