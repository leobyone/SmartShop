using System.Threading.Tasks;
using Abp.Application.Services;
using SmartShop.Authorization.Accounts.Dto;

namespace SmartShop.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
