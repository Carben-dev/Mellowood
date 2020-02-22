using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Mellowood.Configuration;

namespace Mellowood.Web.Host.Startup
{
    [DependsOn(
       typeof(MellowoodWebCoreModule))]
    public class MellowoodWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MellowoodWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MellowoodWebHostModule).GetAssembly());
        }
    }
}
