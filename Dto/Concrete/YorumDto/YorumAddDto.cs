using Core.Dto;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dto.Concrete.YorumDto
{
    public class YorumAddDto:IDto
    {
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorumm { get; set; }
        public int BlogId { get; set; }
    }
}
