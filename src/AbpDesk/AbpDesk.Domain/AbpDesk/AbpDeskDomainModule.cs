﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace AbpDesk
{
    [DependsOn(typeof(AbpDddDomainModule))]
    public class AbpDeskDomainModule : AbpModule
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddAssemblyOf<AbpDeskDomainModule>();
        }
    }
}
