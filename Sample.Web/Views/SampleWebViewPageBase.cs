using Abp.Web.Mvc.Views;

namespace Sample.Web.Views
{
    public abstract class SampleWebViewPageBase : SampleWebViewPageBase<dynamic>
    {

    }

    public abstract class SampleWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected SampleWebViewPageBase()
        {
            LocalizationSourceName = SampleConsts.LocalizationSourceName;
        }
    }
}