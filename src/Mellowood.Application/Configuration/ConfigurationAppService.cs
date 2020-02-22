using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Mellowood.Configuration.Dto;

namespace Mellowood.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MellowoodAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
