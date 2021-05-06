using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.Core.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        /// <summary>
        /// Lấy toàn bộ dữ liệu
        /// </summary>
        /// <returns>Danh sách các bản ghi</returns>
        public IEnumerable<T> GetAll();

        /// <summary>
        /// Lấy theo Id
        /// </summary>
        /// <param name="Tentity"></param>
        /// <returns></returns>
        public T GetById(Guid Tentity);

        /// <summary>
        /// Thêm bản ghi mới
        /// </summary>
        /// <param name="Tentity"></param>
        /// <returns>Trả về số bản ghi được thêm vào db</returns>
        public int Insert(T Tentity);

        /// <summary>
        /// Cập  nhật bản ghi
        /// </summary>
        /// <param name="Tentity"></param>
        /// <returns>Trả về số bản ghi được chỉnh sửa</returns>
        public int Update(T Tentity);

        /// <summary>
        /// Xóa bản ghi
        /// </summary>
        /// <param name="TentityId"></param>
        /// <returns>Trả về số bản ghi đã xóa</returns>
        public int Delete(Guid TentityId);
    }
}