using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Gintuay.Models;
using Gintuay.Data;

namespace Gintuay.Controllers
{
    public class PickupOrderController : ControllerBase
    {
        private readonly ApiContext _context;

        public PickupOrderController(ApiContext context)
        {
            _context = context;
        }

        // Create/Edit
        [HttpPost]
        public JsonResult Post(PickupOrder PickupOrder)
        {
            if (PickupOrder.PickupOrderId == 0)
            {
                _context.PickupOrders.Add(PickupOrder);
            }
            else
            {
                var PickupOrderInDb = _context.PickupOrders.Find(PickupOrder.PickupOrderId);
                if (PickupOrderInDb == null)
                    return new JsonResult(NotFound());

                PickupOrderInDb = PickupOrder;
            }

            _context.SaveChanges();

            return new JsonResult(Ok(PickupOrder));
        }

        // Get
        [HttpGet]
        public JsonResult Get(int id)
        {
            var result = _context.PickupOrders.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        // Delete
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var result = _context.PickupOrders.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            _context.PickupOrders.Remove(result);
            _context.SaveChanges();

            return new JsonResult(NoContent());
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            var result = _context.PickupOrders.ToList();

            return new JsonResult(Ok(result));
        }
    }
}
