using Core.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dto.Concrete.BlogDto
{
    public class BlogUpdateDto:IDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Başlık alanı gereklidir")]
        public string Baslik { get; set; }
        [Required(ErrorMessage = "Açıklama alanı gereklidir")]
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }
    }
}
