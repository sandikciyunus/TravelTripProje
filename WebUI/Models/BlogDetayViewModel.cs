using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class BlogDetayViewModel
    {
        public Blog Blog { get; set; }
        //public Yorum Yorum { get; set; }
        public List<Yorum> Yorums { get; set; }
    }
}
