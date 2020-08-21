using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Blog:IEntity
    {
        public int Id { get; set; }
        public string Baslik { get; set; }
        public DateTime Tarih { get; set; } = DateTime.Now;
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }
        public List<Yorum> Yorums { get; set; }
    }
}
