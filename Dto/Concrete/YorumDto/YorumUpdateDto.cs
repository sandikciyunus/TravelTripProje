using Core.Dto;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dto.Concrete.YorumDto
{
    public class YorumUpdateDto:IDto
    {
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        [Required(ErrorMessage ="Yorum alanı boş geçilemez")]
        public string Yorumm { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
