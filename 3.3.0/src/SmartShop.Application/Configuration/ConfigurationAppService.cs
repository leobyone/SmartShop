using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SmartShop.Configuration.Dto;

namespace SmartShop.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SmartShopAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
