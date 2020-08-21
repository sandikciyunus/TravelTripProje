using Core.DataAccess.Entity_Framework;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfYorumDal : EfEntityRepositoryBase<Yorum, TravelContext>, IYorumDal
    {
        public List<Yorum> GetAllWithTable()
        {
            using(var context=new TravelContext())
            {
                return context.Yorums.Include(p => p.Blog).ToList();
            }
        }

        public List<Yorum> GetByBlogId(int id)
        {
            using(var context=new TravelContext())
            {
                return context.Yorums.Where(p => p.BlogId == id).ToList();
            }
        }
    }
}
