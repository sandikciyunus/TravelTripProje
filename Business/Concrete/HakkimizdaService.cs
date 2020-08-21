using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class HakkimizdaService : IHakkimizdaService
    {
        private IHakkimizdaDal _hakkimizdaDal;
        public HakkimizdaService(IHakkimizdaDal hakkimizdaDal)
        {
            _hakkimizdaDal = hakkimizdaDal;
        }
        public void Add(Hakkimizda hakkimizda)
        {
            _hakkimizdaDal.Add(hakkimizda);
        }

        public void Delete(int id)
        {
            var hakkimizda = _hakkimizdaDal.Get(p=>p.Id==id);
            _hakkimizdaDal.Delete(hakkimizda);
        }

        public List<Hakkimizda> GetAll()
        {
            return _hakkimizdaDal.GetList();
        }

        public Hakkimizda GetById(int id)
        {
            return _hakkimizdaDal.Get(p => p.Id == id);
        }

        public void Update(Hakkimizda hakkimizda)
        {
            _hakkimizdaDal.Update(hakkimizda);
        }
    }
}
