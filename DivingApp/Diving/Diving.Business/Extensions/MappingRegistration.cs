using Diving.Business.Mapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diving.Business.Extensions
{
    public static class MappingRegistration
    {
        public static IServiceCollection AddMapperConfiguration(this IServiceCollection services)
        {
            return services.AddAutoMapper(typeof(MappingProfile));
        }
    }
}
