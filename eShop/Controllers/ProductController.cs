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
    public class ProductController : ControllerBase
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
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
            var product = _productService.GetAll();
            if (product.Count() > 0)
            {
                return Ok(product);
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
            var product = _productService.GetById(id);
            if (product == null)
            {
                return StatusCode(204);
            }
            return Ok(product);
        }

        /// <summary>
        /// Thêm mới bản ghi
        /// </summary>
        /// <param name="product"></param>
        /// <returns>201 - thêm thành công (trả về bản ghi vừa thêm)
        /// 204 - thêm thất bại</returns>
        [HttpPost]
        public IActionResult Post(Product product)
        {
            var res = _productService.Insert(product);
            if (res > 0)
            {
                return StatusCode(201, product);
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
        /// <param name="product"></param>
        /// <returns>200 - sửa thành công
        /// 204 - sửa thất bại</returns>
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Product product)
        {
            var res = _productService.Update(product);
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
            var res = _productService.Delete(id);
            if (res > 0)
            {
                return StatusCode(200);
            }
            return NoContent();
        }
    }
}