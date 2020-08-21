using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class BlogListViewModel
    {
        public List<Blog> Blogs { get; set; }
        public List<Blog> LastBlogs { get; set; }
        public List<Blog> LastSixBlogs { get; set; }
        public List<Blog> TenBlogs { get; set; }
    }
}
