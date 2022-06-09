using BackEnd.DTO;
using BackEnd.IService.Manager;
using BackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BackEnd.Controllers.Manager
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly ManagerIService _service;
        public ManagerController(ManagerIService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<dynamic>> getall()
        {
            return Ok(_service.GetAllOrders());
        }
        [HttpGet("product")]
        public ActionResult<IEnumerable<dynamic>> getallproduct()
        {
            return Ok(_service.GetAllproduct());
        }
        [HttpGet("customer")]
        public ActionResult<IEnumerable<dynamic>> getallcustomer()
        {
            return Ok(_service.GetAllpcustomer());
        }
        [HttpPost("add")]
        public ActionResult<Order> addOrder(Order ob)
        {
            if (ob!=null) {
                var newob = new Order();
                newob.OrderDate = ob.OrderDate;
                newob.ProductId = ob.ProductId;
                newob.ApplicationUserId = ob.ApplicationUserId;
                newob.Amount = ob.Amount;
                return Ok(_service.addOrder(newob));
            }return BadRequest();
              
        }
        [HttpPut("search")]
        public ActionResult<Order> search(StringRequest ob)
        {
            
                return Ok(_service.Search(ob));
            

        }

    }
}
