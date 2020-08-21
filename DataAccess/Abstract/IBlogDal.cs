using Core.DataAcces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBlogDal:IEntityRepository<Blog>
    {
        List<Blog> LastBlogs();
        List<Blog> TenBlogs();
        List<Blog> LastSixBlogs();
        List<Blog> SliderLastBlogs();
        List<Blog> SliderLastBlogs2();
    }
}
