using Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        //public int Id { get; set; }
        public string Kullanici { get; set; }
      //  public string Sifre { get; set; }
    }
}
