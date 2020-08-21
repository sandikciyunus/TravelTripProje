using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IHakkimizdaService
    {
        List<Hakkimizda> GetAll();
        Hakkimizda GetById(int id);
        void Add(Hakkimizda hakkimizda);
        void Update(Hakkimizda hakkimizda);
        void Delete(int id);
    }
}
