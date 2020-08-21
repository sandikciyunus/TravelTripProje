using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IYorumService
    {
        List<Yorum> GetList();
        List<Yorum> GetAllWithTable();
        List<Yorum> GetByBlogId(int id);
        Yorum GetById(int id);
        void Add(Yorum yorum);
        void Update(Yorum yorum);
        void Delete(int id);
    }
}
