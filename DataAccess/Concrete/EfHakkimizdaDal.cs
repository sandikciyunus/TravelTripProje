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
    public class EfHakkimizdaDal : EfEntityRepositoryBase<Hakkimizda, TravelContext>, IHakkimizdaDal
    {
        
    }
}
