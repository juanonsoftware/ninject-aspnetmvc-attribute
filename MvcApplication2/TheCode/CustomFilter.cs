using System.Web.Mvc;
using Ninject;

namespace MvcApplication2.TheCode
{
    public class CustomFilter : ActionFilterAttribute
    {
        [Inject]
        public IService Service { get; set; }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            Service.Validate();
        }
    }
}