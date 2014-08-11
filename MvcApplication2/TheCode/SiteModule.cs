using System.Web.Mvc;
using Ninject.Modules;
using Ninject.Web.Mvc.FilterBindingSyntax;

namespace MvcApplication2.TheCode
{
    public class SiteModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IService>().To<ServiceImpl>();

            Kernel.BindFilter<CustomFilter>(FilterScope.Action, 0);
        }
    }
}