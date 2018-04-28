using Abp.AutoMapper;
using SmartShop.Sessions.Dto;

namespace SmartShop.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}