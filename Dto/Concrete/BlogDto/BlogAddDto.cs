using Core.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Dto.Concrete.BlogDto
{
    public class BlogAddDto:IDto
    {
        [Required(ErrorMessage = "Başlık alanı gereklidir")]
        public string Baslik { get; set; }
        [Required(ErrorMessage = "Açılama alanı gereklidir")]
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }
    }
}
