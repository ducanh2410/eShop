using eShop.Core.Entities;
using eShop.Core.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Controllers
{
    [Route("api/v1/[controller]s")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        /// <summary>
        /// Lấy toàn bộ dữ liệu
        /// </summary>
        /// <returns>
        /// 200 - thành công
        /// 204 - lỗi
        /// </returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            var order = _orderService.GetAll();
            if (order.Count() > 0)
            {
                return Ok(order);
            }
            else
            {
                return NoContent();
            }
        }

        /// <summary>
        /// Lấy theo id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>200 - thành công
        /// 404 - Id không tồn tại
        /// </returns>
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var order = _orderService.GetById(id);
            if (order == null)
            {
                return StatusCode(204);
            }
            return Ok(order);
        }

        /// <summary>
        /// Thêm mới bản ghi
        /// </summary>
        /// <param name="order"></param>
        /// <returns>201 - thêm thành công (trả về bản ghi vừa thêm)
        /// 204 - thêm thất bại</returns>
        [HttpPost]
        public IActionResult Post(Order order)
        {
            var res = _orderService.Insert(order);
            if (res > 0)
            {
                return StatusCode(201, order);
            }
            else
            {
                return NoContent();
            }
        }

        /// <summary>
        /// Sửa bản ghi
        /// </summary>
        /// <param name="id"></param>
        /// <param name="order"></param>
        /// <returns>200 - sửa thành công
        /// 204 - sửa thất bại</returns>
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Order order)
        {
            var res = _orderService.Update(order);
            if (res > 0)
            {
                return StatusCode(200);
            }
            else
            {
                return NoContent();
            }
        }

        /// <summary>
        /// Xóa bản ghi
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// 200 - xóa thành công
        /// 204 - xóa thất bại</returns>
        [HttpDelete("{id}")]
        public IActionResult Detele(Guid id)
        {
            var res = _orderService.Delete(id);
            if (res > 0)
            {
                return StatusCode(200);
            }
            return NoContent();
        }
    }
}