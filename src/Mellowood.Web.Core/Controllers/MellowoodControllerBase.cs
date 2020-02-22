using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Mellowood.Controllers
{
    public abstract class MellowoodControllerBase: AbpController
    {
        protected MellowoodControllerBase()
        {
            LocalizationSourceName = MellowoodConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
