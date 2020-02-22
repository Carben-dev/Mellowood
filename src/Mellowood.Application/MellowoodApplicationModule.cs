using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Mellowood.Authorization;

namespace Mellowood
{
    [DependsOn(
        typeof(MellowoodCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MellowoodApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MellowoodAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MellowoodApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
