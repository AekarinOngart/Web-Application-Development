using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Gintuay.Models;
using Gintuay.Data;

namespace Gintuay.Controllers
{
    public class AddonController : ControllerBase
    {
        private readonly ApiContext _context;

        public AddonController(ApiContext context)
        {
            _context = context;
        }

        // Create/Edit
        [HttpPost]
        public JsonResult Post(Addon Addon)
        {
            if (Addon.AddonId == 0)
            {
                _context.Addons.Add(Addon);
            }
            else
            {
                var AddonInDb = _context.Addons.Find(Addon.AddonId);
                if (AddonInDb == null)
                    return new JsonResult(NotFound());

                AddonInDb = Addon;
            }

            _context.SaveChanges();

            return new JsonResult(Ok(Addon));
        }

        // Get
        [HttpGet]
        public JsonResult Get(int id)
        {
            var result = _context.Addons.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        // Delete
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var result = _context.Addons.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            _context.Addons.Remove(result);
            _context.SaveChanges();

            return new JsonResult(NoContent());
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            var result = _context.Addons.ToList();

            return new JsonResult(Ok(result));
        }
    }
}
