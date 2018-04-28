using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SmartShop.MultiTenancy.Dto;

namespace SmartShop.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
