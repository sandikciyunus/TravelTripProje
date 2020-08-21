using Core.DataAcces;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IYorumDal:IEntityRepository<Yorum>
    {
        List<Yorum> GetByBlogId(int id);
        List<Yorum> GetAllWithTable();
       
    }
}
