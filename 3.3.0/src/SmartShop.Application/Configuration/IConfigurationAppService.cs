using System.Threading.Tasks;
using Abp.Application.Services;
using SmartShop.Configuration.Dto;

namespace SmartShop.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}