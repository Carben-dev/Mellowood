using System.Threading.Tasks;
using Abp.Application.Services;
using Mellowood.Sessions.Dto;

namespace Mellowood.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
