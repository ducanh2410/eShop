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
    public class OrderDetailController : ControllerBase
    {
        private IOrderDetailService _orderDetailService;

        public OrderDetailController(IOrderDetailService categoryService)
        {
            _orderDetailService = categoryService;
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
            var orderDetail = _orderDetailService.GetAll();
            if (orderDetail.Count() > 0)
            {
                return Ok(orderDetail);
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
            var customer = _orderDetailService.GetById(id);
            if (customer == null)
            {
                return StatusCode(204);
            }
            return Ok(customer);
        }

        /// <summary>
        /// Thêm mới bản ghi
        /// </summary>
        /// <param name="orderDetail"></param>
        /// <returns>201 - thêm thành công (trả về bản ghi vừa thêm)
        /// 204 - thêm thất bại</returns>
        [HttpPost]
        public IActionResult Post(OrderDetail orderDetail)
        {
            var res = _orderDetailService.Insert(orderDetail);
            if (res > 0)
            {
                return StatusCode(201, orderDetail);
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
        /// <param name="orderDetail"></param>
        /// <returns>200 - sửa thành công
        /// 204 - sửa thất bại</returns>
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, OrderDetail orderDetail)
        {
            var res = _orderDetailService.Update(orderDetail);
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
            var res = _orderDetailService.Delete(id);
            if (res > 0)
            {
                return StatusCode(200);
            }
            return NoContent();
        }
    }
}