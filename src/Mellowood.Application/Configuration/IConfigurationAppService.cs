using System.Threading.Tasks;
using Mellowood.Configuration.Dto;

namespace Mellowood.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
