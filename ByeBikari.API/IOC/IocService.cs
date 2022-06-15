using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByeBikari.API.IOC
{
    public static class IocService
    {
        public static IServiceCollection iocService(this IServiceCollection serv)
        {
            //return serv.AddScoped<IPostRepository, PostRepositorys>()
            //    .AddScoped<IPostServices, PostServices>();
            return null;
        }
    }
}
