using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Gintuay.Models;
using Gintuay.Data;

namespace Gintuay.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BuyOrderController : ControllerBase
    {
        private readonly ApiContext _context;

        public BuyOrderController(ApiContext context)
        {
            _context = context;
        }

        // Create/Edit
        [HttpPost]
        public JsonResult Post(BuyOrder BuyOrder)
        {
            if (BuyOrder.BuyOrderId == 0)
            {
                _context.BuyOrders.Add(BuyOrder);
            }
            else
            {
                var BuyOrderInDb = _context.BuyOrders.Find(BuyOrder.BuyOrderId);
                if (BuyOrderInDb == null)
                    return new JsonResult(NotFound());

                BuyOrderInDb = BuyOrder;
            }

            _context.SaveChanges();

            return new JsonResult(Ok(BuyOrder));
        }

        // Get
        [HttpGet]
        public JsonResult Get(int id)
        {
            var result = _context.BuyOrders.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        // Delete
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            var result = _context.BuyOrders.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            _context.BuyOrders.Remove(result);
            _context.SaveChanges();

            return new JsonResult(NoContent());
        }

        [HttpGet()]
        public JsonResult GetAll()
        {
            var result = _context.BuyOrders.ToList();

            return new JsonResult(Ok(result));
        }

    }
}
