using Hotel.DBContext;
using Hotel.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hotel.Core
{
    public class GeneralHelperController : Controller
    {
        protected readonly IConfiguration _configuration;
        protected readonly AppDbContext _dbContext;
        public GeneralHelperController(IConfiguration configuration, AppDbContext dbContext)
        {
            _configuration = configuration;
            _dbContext = dbContext;
        }
        protected User? GetUser()
        {
            var userJson = HttpContext.Session.GetString("pm_si");

            if (!string.IsNullOrEmpty(userJson))
            {
                var user = JsonConvert.DeserializeObject<User>(userJson);

                if (user != null)
                {
                    return user;
                }
            }
            return null;
        }
    }
}
