using System.Threading.Tasks;
using Abp.Application.Services;
using SmartShop.Sessions.Dto;

namespace SmartShop.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
