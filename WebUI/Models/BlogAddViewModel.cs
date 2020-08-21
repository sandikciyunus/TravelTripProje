using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class BlogAddViewModel
    {
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }
    }
}
