using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<HakkimizdaService>().As<IHakkimizdaService>();
            builder.RegisterType<EfHakkimizdaDal>().As<IHakkimizdaDal>();

            builder.RegisterType<BlogService>().As<IBlogService>();
            builder.RegisterType<EfBlogDal>().As<IBlogDal>();

            builder.RegisterType<YorumService>().As<IYorumService>();
            builder.RegisterType<EfYorumDal>().As<IYorumDal>();
        }
    }
}
