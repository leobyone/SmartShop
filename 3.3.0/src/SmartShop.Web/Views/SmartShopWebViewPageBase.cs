using Abp.Web.Mvc.Views;

namespace SmartShop.Web.Views
{
    public abstract class SmartShopWebViewPageBase : SmartShopWebViewPageBase<dynamic>
    {

    }

    public abstract class SmartShopWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SmartShopWebViewPageBase()
        {
            LocalizationSourceName = SmartShopConsts.LocalizationSourceName;
        }
    }
}