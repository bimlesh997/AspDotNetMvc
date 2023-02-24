using Abp.Web.Mvc.Views;

namespace test2.Web.Views
{
    public abstract class test2WebViewPageBase : test2WebViewPageBase<dynamic>
    {

    }

    public abstract class test2WebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected test2WebViewPageBase()
        {
            LocalizationSourceName = test2Consts.LocalizationSourceName;
        }
    }
}