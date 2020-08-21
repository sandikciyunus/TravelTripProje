using Core.DataAccess.Entity_Framework;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfBlogDal : EfEntityRepositoryBase<Blog, TravelContext>, IBlogDal
    {
        public List<Blog> LastBlogs()
        {
            using(var context=new TravelContext())
            {
                return context.Blogs.Take(3).OrderByDescending(p=>p.Id).ToList();
            }
        }
        public List<Blog> LastSixBlogs()
        {
            using (var context = new TravelContext())
            {
                return context.Blogs.Take(3).ToList();
            }
        }
        public List<Blog> TenBlogs()
        {
            using (var context = new TravelContext())
            {
                return context.Blogs.Take(10).OrderByDescending(p => p.Id).ToList();
            }
        }


        public List<Blog> SliderLastBlogs()
        {
            using (var context = new TravelContext())
            {
                return context.Blogs.Take(2).OrderByDescending(p => p.Id).ToList();
            }
        }

        public List<Blog> SliderLastBlogs2()
        {
            using (var context = new TravelContext())
            {
                var blog = (from blogg in context.Blogs
                           orderby blogg.Id ascending
                           select new Blog
                           {
                               Id = blogg.Id,
                               Baslik=blogg.Baslik,
                               Tarih=blogg.Tarih,
                               Aciklama=blogg.Aciklama,
                               BlogImage=blogg.BlogImage
                           }).Take(1);
                return blog.ToList();
            }
        }
    }
}
