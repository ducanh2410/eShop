using eShop.Core.Entities;
using eShop.Core.Interfaces;
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
    public class CustomerController : ControllerBase
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
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
            var customers = _customerService.GetAll();
            if (customers.Count() > 0)
            {
                return Ok(customers);
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
            var customer = _customerService.GetById(id);
            if (customer == null)
            {
                return StatusCode(204);
            }
            return Ok(customer);
        }

        /// <summary>
        /// Thêm mới bản ghi
        /// </summary>
        /// <param name="customer"></param>
        /// <returns>201 - thêm thành công (trả về bản ghi vừa thêm)
        /// 204 - thêm thất bại</returns>
        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            var res = _customerService.Insert(customer);
            if (res > 0)
            {
                return StatusCode(201, customer);
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
        /// <param name="customer"></param>
        /// <returns>200 - sửa thành công
        /// 204 - sửa thất bại</returns>
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Customer customer)
        {
            var res = _customerService.Update(customer);
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
            var res = _customerService.Delete(id);
            if (res > 0)
            {
                return StatusCode(200);
            }
            return NoContent();
        }
    }
}