using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Mellowood.MultiTenancy.Dto;

namespace Mellowood.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

