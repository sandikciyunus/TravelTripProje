using Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dto.Concrete.YorumDto
{
    public class YorumListDto:IDto
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorumm { get; set; }
        public int BlogId { get; set; }
    }
}
