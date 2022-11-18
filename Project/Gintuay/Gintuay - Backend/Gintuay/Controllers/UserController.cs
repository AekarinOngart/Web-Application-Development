using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Gintuay.Models;
using Gintuay.Data;

namespace Gintuay.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly ApiContext _context;

        public UserController(ApiContext context)
        {
            _context = context;
        }

        // Create/Edit
        [HttpPost]
        public JsonResult Post(User user)
        {
            if(user.Id == 0)
            {
                _context.Users.Add(user);
            } else
            {
                var userInDb = _context.Users.Find(user.Id);
                if (userInDb == null)
                    return new JsonResult(NotFound());

                userInDb = user;
            }

            _context.SaveChanges();

            return new JsonResult(Ok(user));
        }

        // Get
        [HttpGet]
        public JsonResult Get(int id)
        {
            var result = _context.Users.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        // Delete
        [HttpDelete]
        public JsonResult Delete(int id) 
        {
            var result = _context.Users.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            _context.Users.Remove(result);
            _context.SaveChanges();

            return new JsonResult(NoContent());
        }

        [HttpGet()]
        public JsonResult GetAll()
        {
            var result = _context.Users.ToList();

            return new JsonResult(Ok(result));
        }
    }
}
