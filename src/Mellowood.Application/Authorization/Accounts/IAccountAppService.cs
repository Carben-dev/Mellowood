using System.Threading.Tasks;
using Abp.Application.Services;
using Mellowood.Authorization.Accounts.Dto;

namespace Mellowood.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
