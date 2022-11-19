using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Gintuay.Models;
using Gintuay.Data;

namespace Gintuay.Controllers
{
    public class ImageController : ControllerBase
    {
        private readonly ApiContext _context;

        public ImageController(ApiContext context)
        {
            _context = context;
            //Console.WriteLine(context);
        }
        // Create/Edit
        [HttpPost]
        public JsonResult Post(Image Image)
        {
            if (Image.ImageId == 0)
            {
                _context.Images.Add(Image);
            }
            else
            {
                var ImageInDb = _context.Images.Find(Image.ImageId);
                if (ImageInDb == null)
                    return new JsonResult(NotFound());

                ImageInDb = Image;
            }

            _context.SaveChanges();

            return new JsonResult(Ok(Image));
        }

        [HttpGet]
        public JsonResult Get(int id)
        {
            var result = _context.Images.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var result = _context.Images.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            _context.Images.Remove(result);
            _context.SaveChanges();

            return new JsonResult(NoContent());
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            var result = _context.Images.ToList();

            return new JsonResult(Ok(result));
        }
    }
}
