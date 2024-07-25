using Microsoft.AspNetCore.Mvc.Filters;

namespace WebHelloMVC1.Filters
{
    public class MyActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var methodName = context.ActionDescriptor.RouteValues["action"];

            Console.WriteLine($"Текущий метод: {methodName}");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Action result: " + context.Result);
        }
    }
}
