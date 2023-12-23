using Hotel.DBContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
namespace Hotel.Core
{
    public class ClientCoreController : GeneralHelperController
    {
        public ClientCoreController(IConfiguration configuration, AppDbContext dbContext) : base(configuration, dbContext)
        {
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var User = GetUser();
            if (User == null)
            {
                HttpContext.Session.Clear();
                context.Result = RedirectToAction("Login", "Account");
                return;
            }

            bool check_user = _dbContext.Users.Any(u => u.Id == User.Id && u.Level == 2);
            if (!check_user)
            {
                context.Result = RedirectToAction("Login");
                return;
            }

            base.OnActionExecuting(context);
        }

    }
}
