using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Gintuay.Models;
using Gintuay.Data;

namespace Gintuay.Controllers
{
    //[ApiController]
    //[Route("api/[controller]/[action]")]
    public class UserController : Controller
    {
        private readonly ApiContext _context;

        public UserController(ApiContext context)
        {
            _context = context;
            //Console.WriteLine(context);
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

        [HttpPut]
        public JsonResult Put(User user)
        {
          
                var userInDb = _context.Users.Find(user.Id);
                if (userInDb == null)
                {
                    return new JsonResult(NotFound());
                }
                else
                {
                    userInDb.Id= user.Id;
                    userInDb.Username = user.Username;
                    userInDb.Password = user.Password;
                    userInDb.Email = user.Email;
                    userInDb.Qrcode = user.Qrcode;
                    userInDb.Phone = user.Phone;
                    userInDb.Profile_pic = user.Profile_pic;   
            }




            _context.SaveChanges();

            return new JsonResult(Ok(userInDb));
        }

        [HttpGet]
        public JsonResult Get(int id)
        {
            var result = _context.Users.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

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

        [HttpGet]
        public JsonResult GetAll()
        {
            var result = _context.Users.ToList();

            return new JsonResult(Ok(result));
        }
    }
}
