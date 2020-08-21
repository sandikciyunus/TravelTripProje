using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBlogService
    {
        List<Blog> GetAll();
        List<Blog> LastBlogs();
        List<Blog> LastSixBlogs();
        List<Blog> TenBlogs();
        List<Blog> SliderLastBlogs2();
        List<Blog> SliderLastBlogs();
        Blog GetById(int id);
        void Add(Blog blog);
        void Update(Blog blog);
        void Delete(int id);
    }
}
