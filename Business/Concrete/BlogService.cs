using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BlogService : IBlogService
    {
        private IBlogDal _blogDal;
        public BlogService(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public void Add(Blog blog)
        {
            _blogDal.Add(blog);
        }

        public void Delete(int id)
        {
            var blog = _blogDal.Get(p => p.Id == id);
            _blogDal.Delete(blog);
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetList();
        }

        public Blog GetById(int id)
        {
            return _blogDal.Get(p => p.Id == id);
        }

        public List<Blog> LastBlogs()
        {
            return _blogDal.LastBlogs();
        }

        public List<Blog> LastSixBlogs()
        {
            return _blogDal.LastSixBlogs();
        }

        public List<Blog> SliderLastBlogs()
        {
            return _blogDal.SliderLastBlogs();
        }

        public List<Blog> SliderLastBlogs2()
        {
            return _blogDal.SliderLastBlogs2();
        }

        public List<Blog> TenBlogs()
        {
            return _blogDal.TenBlogs();
        }

        public void Update(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
