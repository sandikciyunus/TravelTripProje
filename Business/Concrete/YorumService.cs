using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class YorumService : IYorumService
    {
        private IYorumDal _yorumDal;
        public YorumService(IYorumDal yorumDal)
        {
            _yorumDal = yorumDal;
        }
        public void Add(Yorum yorum)
        {
            _yorumDal.Add(yorum);
        }

        public void Delete(int id)
        {
            var yorum = _yorumDal.Get(p => p.Id == id);
            _yorumDal.Delete(yorum);
        }

        public List<Yorum> GetAllWithTable()
        {
            return _yorumDal.GetAllWithTable();
        }

        public List<Yorum> GetByBlogId(int id)
        {
            return _yorumDal.GetByBlogId(id);
        }

        public Yorum GetById(int id)
        {
            return _yorumDal.Get(p => p.Id == id);
        }

        public List<Yorum> GetList()
        {
            return _yorumDal.GetList();
        }

        public void Update(Yorum yorum)
        {
            _yorumDal.Update(yorum);
        }
    }
}
