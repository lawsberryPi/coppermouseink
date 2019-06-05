using Microsoft.AspNetCore.Mvc;
using CopperMouseNetVue.Model;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Text;
using System.Data.Entity;
using System.Linq;

namespace CopperMouseNetVue.Controllers
{
    public class UserManagerController : Controller
    {
        private readonly CopperMouseInkContext _context;

        public UserManagerController(CopperMouseInkContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<Table> AddUser(string userObject)
        {
            LoginInfo userInfo = JsonConvert.DeserializeObject<LoginInfo>(userObject);
            byte[] imageBytes = Encoding.ASCII.GetBytes("example");
            var newUser = new Table() { UserEmail = userInfo.userEmail, UserCart="cart", UserImage= imageBytes };

            var queryUser = (from user in _context.Table
                            where user.UserEmail == userInfo.userEmail
                            select user).ToList();
            if (queryUser.Count == 0)
            {
                await _context.Table.AddAsync(newUser);
                await _context.SaveChangesAsync();
                queryUser.Add(newUser);
            }
            return queryUser.FirstOrDefault();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
