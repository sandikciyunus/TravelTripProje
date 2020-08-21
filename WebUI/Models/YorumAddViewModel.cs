using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class YorumAddViewModel
    {
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorumm { get; set; }
        public int BlogId { get; set; }
    }
}
